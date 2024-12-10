using BetterCallRoomy.Properties;
using HotelBusinessLogic.HotelController;
using HotelModel.GuestModel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace BetterCallRoomy
{
    public partial class GuestProfiles : Form
    {
        private GuestController guest;
        private System.Windows.Forms.Timer timecount;
        private bool timeRegistered = true;

        public GuestProfiles()
        {
            InitializeComponent();
            guest = new GuestController();
            dataViewList.CellClick += dataViewList_CellContentClick;
            timecount = new System.Windows.Forms.Timer();
            timecount.Interval = 1000;
            timecount.Tick += Timecount_Tick;
            timecount.Start();

        }

        private void Timecount_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (timeRegistered)
            {
                dateRegistered.Value = new DateTime(dateRegistered.Value.Year, dateRegistered.Value.Month, dateRegistered.Value.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
            }

        }

        private void dateBirthDate_ValueChanged(object sender, EventArgs e)
        {
            var day = DateTime.Today;
            var BirthDate = dateBirthDate.Value;
            var age = day.Year - BirthDate.Year;

            if (BirthDate.Date > day.AddYears(-age)) age--;
            lblAge.Text = age.ToString();

        }

        private void WriteGuestInfoToFile(string firstName, string middleName, string lastName, DateTime birthDate, string age, string gender, string ethnicity, string email, string contactNo, DateTime registeredDate)
        {
            string fileName = $"{firstName} {middleName} {lastName}.txt";
            string filePath = Path.Combine(@"C:\\Users\\Julius Mendoza\\source\\repos\\ErvinAbiadSTI\\BT3102.Group7.App\\BetterCallRoomy\\Resources\\GuestInfos", fileName);

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine($"Guest ID: {Guid.NewGuid()}");
                    writer.WriteLine($"First Name: {firstName}");
                    writer.WriteLine($"Middle Name: {middleName}");
                    writer.WriteLine($"Last Name: {lastName}");
                    writer.WriteLine($"Birth Date: {birthDate.ToShortDateString()}");
                    writer.WriteLine($"Age: {age}");
                    writer.WriteLine($"Ethnicity: {ethnicity}");
                    writer.WriteLine($"Email: {email}");
                    writer.WriteLine($"Contact No: {contactNo}");
                    writer.WriteLine($"Time Registered: {registeredDate.ToShortDateString()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuestInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text.Trim();
                string middleName = txtMiddleName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string age = lblAge.Text.Trim();
                string gender = cbGender.Text.Trim();
                string ethnic = cbEthnic.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contactNo = txtContactNo.Text.Trim();

                DateTime Birth = dateBirthDate.Value;
                DateTime registered = dateRegistered.Value;

                GuestModel guestModel = guest.GetGuestModel(firstName, middleName, lastName, Birth, age, gender, ethnic, email, contactNo, registered);
                LoadGuestsList();

                WriteGuestInfoToFile(firstName, middleName, lastName, Birth, age, gender, ethnic, email, contactNo, registered);

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                dateBirthDate.Value = DateTime.Now;
                lblAge.Text = string.Empty;
                cbGender.SelectedIndex = -1;
                cbEthnic.SelectedIndex = -1;
                txtEmail.Clear();
                txtContactNo.Clear();
                dateRegistered.Value = DateTime.Now;
                timeRegistered = true;
            }
            catch (ArgumentException AE)
            {
                MessageBox.Show(AE.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataViewList.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a guest to update.");
                }

                string firstName = txtFirstName.Text.Trim();
                string middleName = txtMiddleName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string age = lblAge.Text.Trim();
                string gender = cbGender.Text.Trim();
                string ethnic = cbEthnic.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contactNo = txtContactNo.Text.Trim();

                DataGridViewRow selectedRow = dataViewList.SelectedRows[0];
                DateTime existingBookedDate = Convert.ToDateTime(selectedRow.Cells[10].Value);

                DateTime Birth = dateBirthDate.Value;
                DateTime registered = dateRegistered.Value;

                guest.UpdateGuest(dataViewList.SelectedRows, firstName, middleName, lastName, Birth, age, gender, ethnic, email, contactNo, registered);
                LoadGuestsList();

                WriteGuestInfoToFile(firstName, middleName, lastName, Birth, age, gender, ethnic, email, contactNo, registered);

                MessageBox.Show("Guest information updated successfully.");

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                dateBirthDate.Value = DateTime.Now;
                lblAge.Text = string.Empty;
                cbGender.SelectedIndex = -1;
                cbEthnic.SelectedIndex = -1;
                txtEmail.Clear();
                txtContactNo.Clear();
                dateRegistered.Value = DateTime.Now;
                timeRegistered = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime registered = dateRegistered.Value;

                guest.DeleteGuest(dataViewList.SelectedRows);

                LoadGuestsList();
                MessageBox.Show("Guest information deleted successfully.");

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                dateBirthDate.Value = DateTime.Now;
                lblAge.Text = string.Empty;
                cbGender.SelectedIndex = -1;
                cbEthnic.SelectedIndex = -1;
                txtEmail.Clear();
                txtContactNo.Clear();
                dateRegistered.Value = DateTime.Now;
                timeRegistered = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            dateBirthDate.Value = DateTime.Now;
            lblAge.Text = string.Empty;
            cbGender.SelectedIndex = -1;
            cbEthnic.SelectedIndex = -1;
            txtEmail.Clear();
            txtContactNo.Clear();
            dateRegistered.Value = DateTime.Now;
            timeRegistered = true;
            dataViewList.ClearSelection();
        }

        private void LoadGuestsList()
        {
            List<GuestModel> guests = guest.FetchAllGuests();
            dataViewList.DataSource = guests;
            lblAge.Text = string.Empty;
            dateRegistered.Enabled = false;
        }

        private void GuestProfiles_Load(object sender, EventArgs e)
        {
            LoadGuestsList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string searchType = string.Empty;

            if (rbName.Checked)
            {
                searchType = "Name";
            }
            else if (rbEmail.Checked)
            {
                searchType = "Email";
            }
            else if (rbID.Checked)
            {
                searchType = "ID";
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadGuestsList();
                return;
            }

            try
            {
                List<GuestModel> guests = guest.SearchGuests(searchTerm, searchType);
                if (guests.Count > 0)
                {
                    dataViewList.DataSource = guests;
                }
                else
                {
                    dataViewList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataViewList.DataSource = null;
            }
        }

        private void dataViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataViewList.Rows.Count)
            {
                DataGridViewRow selectedRow = dataViewList.Rows[e.RowIndex];
                txtFirstName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtMiddleName.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                txtLastName.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(selectedRow.Cells[4].Value?.ToString(), out DateTime birthDate))
                {
                    dateBirthDate.Value = birthDate;
                }

                lblAge.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                cbGender.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                cbEthnic.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells[8].Value?.ToString() ?? string.Empty;
                txtContactNo.Text = selectedRow.Cells[9].Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(selectedRow.Cells[10].Value?.ToString(), out DateTime dateregistered))
                {
                    dateRegistered.Value = dateregistered;
                }

                timeRegistered = false;
            }
        }
    }
}
