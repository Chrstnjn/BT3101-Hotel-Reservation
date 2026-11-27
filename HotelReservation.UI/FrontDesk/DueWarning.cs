using System.Data;
using System.Text;

namespace HotelReservation.UI.FrontDesk
{
    public static class DueWarning
    {
        private const string PesoFormat = "₱#,##0.00";

        // Shows one popup for all guests who must pay and leave now
        public static void Show(IWin32Window owner, DataTable checkOuts)
        {
            DataRow[] late = checkOuts.Select("MustLeave = 1");
            if (late.Length == 0)
                return;

            StringBuilder sb = new StringBuilder(
                "These guests are past check-out time, and another guest is booked for their room:\n\n");

            foreach (DataRow r in late)
            {
                decimal balance = Convert.ToDecimal(r["Balance"]);
                DateTime next = Convert.ToDateTime(r["NextCheckInDate"]);

                sb.AppendLine($"• {r["GuestName"]} - Room {r["RoomNumber"]}");
                sb.AppendLine($"   Next guest arrives: {next:MM/dd/yyyy hh:mm tt}");
                sb.AppendLine(balance > 0
                    ? $"   Must pay {balance.ToString(PesoFormat)} and check out now."
                    : "   Already paid. Must check out now.");
                sb.AppendLine();
            }

            MessageBox.Show(owner, sb.ToString(), "Payment Due",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}