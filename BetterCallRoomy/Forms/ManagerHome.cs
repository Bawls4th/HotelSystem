

using BetterCallRoomy.CustomerForm;
using BetterCallRoomy.Forms;

namespace BetterCallRoomy.ReceptionistForm
{
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            this.Hide();
            login.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guestProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestProfiles guestProfiles = new GuestProfiles();
            guestProfiles.Show();
        }

        private void servicorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }

        private void bookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
        }

        private void roomInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomMaintenance roomMaintenance = new RoomMaintenance();
            roomMaintenance.Show();
        }

        private void receptionistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReceptionist addReceptionist = new AddReceptionist();
            addReceptionist.Show();
        }
    }
}
