using System.Drawing.Printing;

namespace HotelReservation.UI.FrontDesk
{
    // All the information that is printed on the receipt
    public class ReceiptData
    {
        public string ReservationNumber = "";
        public string GuestName = "";
        public string PhoneNumber = "";
        public string RoomNumber = "";
        public string RoomType = "";
        public DateTime CheckIn;
        public DateTime CheckedInAt;
        public DateTime CheckOut;
        public DateTime CheckedOutAt;
        public int Nights;
        public decimal Rate;
        public decimal TotalCharges;
        public decimal Paid;
        public decimal Balance;
    }

    // Used by frmCheckOut (after a check-out) and frmFrontBillingRecord (Print button)
    public static class ReceiptPrinter
    {
        private const string DateTimeFormat = "MM/dd/yyyy hh:mm tt";
        private const string PesoFormat = "₱#,##0.00";

        // Opens the print preview of the receipt
        public static void Show(IWin32Window owner, ReceiptData data)
        {
            using (PrintDocument doc = new PrintDocument())
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                doc.DocumentName = "Receipt " + data.ReservationNumber;
                doc.PrintPage += (s, e) => DrawReceipt(e, data);

                preview.Document = doc;
                preview.Text = "Check-Out Receipt";
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog(owner);
            }
        }

        // 9171234503, 09171234503, 639171234503 and (+63) 9171234503 all become (+63) 9171234503
        public static string FormatPhone(string phone)
        {
            string digits = new string(phone.Where(char.IsDigit).ToArray());

            if (digits.StartsWith("63") && digits.Length >= 12)
                digits = digits.Substring(2);
            else if (digits.StartsWith("0"))
                digits = digits.Substring(1);

            return digits.Length == 0 ? phone : "(+63) " + digits;
        }

        private static void DrawReceipt(PrintPageEventArgs e, ReceiptData d)
        {
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Color navy = Color.FromArgb(0, 61, 132);
            Color gray = Color.FromArgb(70, 70, 70);
            Color softLine = Color.FromArgb(190, 200, 220);
            Color softFill = Color.FromArgb(234, 239, 246);

            float left = e.MarginBounds.Left;
            float width = e.MarginBounds.Width;
            float right = left + width;
            float y = e.MarginBounds.Top;

            // EDIT YOUR HOTEL RULES HERE
            string[] rules =
            {
                "Check-in starts at 1:00 PM. Check-out is until 12:00 PM.",
                "Smoking is not allowed inside the rooms.",
                "Quiet hours are from 10:00 PM to 6:00 AM.",
                "The hotel is not responsible for lost valuables."
            };

            using (Font titleFont = new Font("Segoe UI Light", 30))
            using (Font receiptFont = new Font("Segoe UI", 24, FontStyle.Bold))
            using (Font headFont = new Font("Segoe UI", 10, FontStyle.Bold))
            using (Font font = new Font("Segoe UI", 10))
            using (Font smallFont = new Font("Segoe UI", 9))
            using (Font iconFont = new Font("Segoe MDL2 Assets", 10))
            using (Brush navyBrush = new SolidBrush(navy))
            using (Brush grayBrush = new SolidBrush(gray))
            using (Brush softBrush = new SolidBrush(softLine))
            using (Brush fillBrush = new SolidBrush(softFill))
            using (Pen navyPen = new Pen(navy, 1.5f))
            using (Pen softPen = new Pen(softLine, 1f))
            {
                // ---------- small helpers ----------
                void TextLeft(string text, Font f, Brush b, float x, float yy, float h = 22)
                {
                    using (StringFormat sf = new StringFormat { LineAlignment = StringAlignment.Center })
                        g.DrawString(text, f, b, new RectangleF(x, yy, 650, h), sf);
                }

                void TextRight(string text, Font f, Brush b, float xRight, float yy, float h = 22)
                {
                    using (StringFormat sf = new StringFormat
                    { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center })
                        g.DrawString(text, f, b, new RectangleF(xRight - 500, yy, 500, h), sf);
                }

                void TextCenter(string text, Font f, Brush b, float yy, float h = 22)
                {
                    using (StringFormat sf = new StringFormat
                    { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                        g.DrawString(text, f, b, new RectangleF(left, yy, width, h), sf);
                }

                // Draws icon + text items on one line, centered on the page
                void IconRow(float yy, params (string Icon, string Text)[] items)
                {
                    const float iconW = 16, gapIcon = 6, gapItem = 26;
                    StringFormat tf = StringFormat.GenericTypographic;

                    float total = gapItem * (items.Length - 1);
                    foreach (var item in items)
                        total += iconW + gapIcon + g.MeasureString(item.Text, smallFont, 1000, tf).Width;

                    float cx = left + (width - total) / 2;

                    foreach (var item in items)
                    {
                        float textW = g.MeasureString(item.Text, smallFont, 1000, tf).Width;

                        g.DrawString(item.Icon, iconFont, navyBrush, cx, yy + 1, tf);
                        g.DrawString(item.Text, smallFont, grayBrush, cx + iconW + gapIcon, yy + 2, tf);

                        cx += iconW + gapIcon + textW + gapItem;
                    }
                }

                // ---------- HEADER ----------
                TextCenter("Highlands Hotel", titleFont, navyBrush, y, 50);
                y += 56;

                IconRow(y, ("\uE707", "168 A. Martinez St., Balayan, Batangas"));   // location icon
                y += 22;
                IconRow(y,
                    ("\uE717", "(+63) 9757-860-560"),                               // phone icon
                    ("\uE715", "highlandshotel@gmail.com"));                        // email icon
                y += 32;

                g.FillRectangle(softBrush, left, y, width, 3);   // divider line
                y += 25;

                // ---------- RESERVATION DETAILS (left) + RECEIPT title (right) ----------
                float sectionTop = y;
                float valueX = left + 100;

                TextLeft("Reservation Details", headFont, navyBrush, left, y);
                y += 26;

                TextLeft("Room No.", font, grayBrush, left, y);
                TextLeft(d.RoomNumber, font, grayBrush, valueX, y);
                y += 22;
                TextLeft("Room Type", font, grayBrush, left, y);
                TextLeft(d.RoomType, font, grayBrush, valueX, y);
                y += 22;

                TextRight("RECEIPT", receiptFont, navyBrush, right, sectionTop, 45);
                y += 20;

                // ---------- GUEST (left) + RESERVATION INFO (right) ----------
                float infoLabelX = left + width * 0.55f;

                TextLeft("Guest", headFont, navyBrush, left, y);
                TextLeft("Reservation #", headFont, navyBrush, infoLabelX, y);
                TextRight(d.ReservationNumber, font, grayBrush, right, y);
                y += 26;

                TextLeft(d.GuestName, font, grayBrush, left, y);
                TextLeft("Checked In", headFont, navyBrush, infoLabelX, y);
                TextRight(d.CheckedInAt.ToString(DateTimeFormat), font, grayBrush, right, y);
                y += 22;

                TextLeft(FormatPhone(d.PhoneNumber), font, grayBrush, left, y);
                TextLeft("Checked Out", headFont, navyBrush, infoLabelX, y);
                TextRight(d.CheckedOutAt.ToString(DateTimeFormat), font, grayBrush, right, y);
                y += 22;

                TextLeft("Status", headFont, navyBrush, infoLabelX, y);
                TextRight("Checked Out", font, grayBrush, right, y);
                y += 40;

                // ---------- TABLE ----------
                float rowH = 28;
                float tableTop = y;
                float colQty = left + 10;
                float colDesc = left + 80;
                float colRateRight = left + width - 150;
                float colAmountRight = right - 12;

                // Header row
                g.FillRectangle(navyBrush, left, y, width, rowH);
                TextLeft("Nights", headFont, Brushes.White, colQty, y, rowH);
                TextLeft("Description", headFont, Brushes.White, colDesc, y, rowH);
                TextRight("Rate Per Night", headFont, Brushes.White, colRateRight, y, rowH);
                TextRight("Amount", headFont, Brushes.White, colAmountRight, y, rowH);
                y += rowH;

                // Item row
                TextLeft(d.Nights.ToString(), font, grayBrush, colQty, y, rowH + 4);
                TextLeft("Room " + d.RoomNumber + " - " + d.RoomType, font, grayBrush, colDesc, y, rowH + 4);
                TextRight(d.Rate.ToString(PesoFormat), font, grayBrush, colRateRight, y, rowH + 4);
                TextRight(d.TotalCharges.ToString(PesoFormat), font, grayBrush, colAmountRight, y, rowH + 4);
                y += rowH + 8;

                g.DrawLine(navyPen, left, y, right, y);

                // Summary rows
                float labelX = left + width * 0.45f;

                TextLeft("Total Charges", font, grayBrush, labelX, y, rowH);
                TextRight(d.TotalCharges.ToString(PesoFormat), font, grayBrush, colAmountRight, y, rowH);
                y += rowH;

                TextLeft("Total Paid", font, grayBrush, labelX, y, rowH);
                TextRight(d.Paid.ToString(PesoFormat), font, grayBrush, colAmountRight, y, rowH);
                y += rowH;

                // Highlighted last row
                g.FillRectangle(fillBrush, left + 1, y, width - 1, rowH);
                g.DrawLine(softPen, left, y, right, y);
                TextLeft("Balance", headFont, navyBrush, labelX, y, rowH);
                TextRight(d.Balance.ToString(PesoFormat), headFont, navyBrush, colAmountRight, y, rowH);
                y += rowH;

                // Table border
                g.DrawRectangle(navyPen, left, tableTop, width, y - tableTop);
                y += 30;

                // ---------- HOTEL RULES ----------
                TextLeft("Hotel Rules", headFont, navyBrush, left, y);
                y += 26;    

                foreach (string rule in rules)
                {
                    TextLeft("•  " + rule, font, grayBrush, left, y);
                    y += 22;
                }

                y += 14;
                TextLeft("Thank you for staying with us!", headFont, navyBrush, left, y);
            }

            e.HasMorePages = false;
        }
    }
}