using BetterCallRoomy.ReceptionistForm;
using HotelBusinessLogic.HotelController;

namespace BetterCallRoomy
{
    public partial class LogInForm : Form
    {
        private ManagerController mc;
        private ReceptionistController rc;
        public LogInForm()
        {
            InitializeComponent();
            mc = new ManagerController();
            rc = new ReceptionistController();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;

            try
            {
                if (rbManager.Checked)
                {
                    var man = mc.GetManModel(username, password);
                    if (man != null)
                    {
                        lblLogic.Text = string.Empty;
                        MessageBox.Show($"Logged in successfully as Admin: [{man.MGID}] {man.MGLastName}, {man.MGFirstName}");
                        txtbxUsername.Clear();
                        txtbxPassword.Clear();
                        ManagerHome managerHome = new ManagerHome();
                        this.Hide();
                        managerHome.Show();

                    }

                }
                else if (rbReceptionist.Checked)
                {
                    var rep = rc.GetEmpModel(username, password);
                    if (rep != null)
                    {
                        lblLogic.Text = string.Empty;
                        MessageBox.Show($"Logged in successfully as Employee: [{rep.RPID}] {rep.RPLastName}, {rep.RPFirstName}");
                        txtbxUsername.Clear();
                        txtbxPassword.Clear();
                        ReceptionistHome receptionistHome = new ReceptionistHome();
                        this.Hide();
                        receptionistHome.Show();
                    }

                }
                else
                {
                    lblLogic.Text = "Please Select Admin or Employee...";
                }
            }

            catch (Exception EX)
            {
                lblLogic.Text = $"{EX.Message}";
            }
        }

        private void cbSP_CheckedChanged(object sender, EventArgs e)
        {
            txtbxPassword.UseSystemPasswordChar = !cbSP.Checked;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            lblLogic.Text =String.Empty;
        }
    }
}
