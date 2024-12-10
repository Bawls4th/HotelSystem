using BetterCallRoomy.CustomerForm;
using BetterCallRoomy.ReceptionistForm;

namespace BetterCallRoomy
{
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }
        private void guestProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestProfiles gp = new GuestProfiles();
            gp.Show();
        }
        private void servicorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerService cs = new CustomerService();
            cs.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm LIG = new LogInForm();
            LIG.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblDate.Text = "Date: " + DateTime.Now.ToLongDateString();
            timerDate.Start();
            lblTime.Text = "Time: " + DateTime.Now.ToLongTimeString();

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time: " + DateTime.Now.ToLongTimeString();
            timerDate.Start();
        }

        private void roomInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomMaintenance rooms = new RoomMaintenance();
            rooms.Show();
        }

        private void bookReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.Show();
        }
    }
}
