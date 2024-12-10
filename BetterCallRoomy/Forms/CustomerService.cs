using HotelBusinessLogic.HotelController;
using HotelModel.CustomerServiceModel;
using System.Windows.Forms;

namespace BetterCallRoomy.CustomerForm
{
    public partial class CustomerService : Form
    {
        private CustomerServiceController servicor;
        private System.Windows.Forms.Timer timecount;
        private bool timeService = true;
        public CustomerService()
        {
            InitializeComponent();
            servicor = new CustomerServiceController();
            timecount = new System.Windows.Forms.Timer();
            timecount.Interval = 1000;
            timecount.Tick += Timecount_Tick;
            timecount.Start();
            dataServiceList.CellClick += dataServiceList_CellContentClick;
        }

        private void Timecount_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (timeService)
            {
                dtpDataService.Value = new DateTime(dtpDataService.Value.Year, dtpDataService.Value.Month, dtpDataService.Value.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
            }

        }

        private void LoadServicorList()
        {
            List<ServicorModel> servicors = servicor.FetchAllService();
            dataServiceList.DataSource = servicors;
            dataServiceList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataServiceList.Columns[7].ReadOnly = true;
        }
        private void CustomerService_Load(object sender, EventArgs e)
        {
            LoadServicorList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string searchType = string.Empty;

            if (rbName.Checked)
            {
                searchType = "Name";
            }
            else if (rbID.Checked)
            {
                searchType = "ID";
            }
            else if (rbAvailability.Checked)
            {
                searchType = "Availability";
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadServicorList();
                return;
            }

            try
            {
                List<ServicorModel> serv = servicor.SearchRooms(searchTerm, searchType);
                if (serv.Count > 0)
                {
                    dataServiceList.DataSource = serv;
                }
                else
                {
                    dataServiceList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataServiceList.DataSource = null;
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string FN = txtFirstName.Text.Trim();
                string MN = txtMiddleName.Text.Trim();
                string LN = txtLastName.Text.Trim();
                string Gender = cbGender.Text.Trim();
                string Description = txtDescription.Text.Trim();
                string price = mtxtPrice.Text.Trim();
                string avail = cbAvailable.Text.Trim();
                DateTime service = dtpDataService.Value;

                ServicorModel servModel = servicor.AddServicor(FN, MN, LN, Gender, Description, price, avail, service);

                LoadServicorList();

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                cbGender.SelectedIndex = -1;
                txtDescription.Clear();
                mtxtPrice.Clear();
                cbAvailable.SelectedIndex = -1;
                dtpDataService.Value = DateTime.Now;
                bool timeService = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataServiceList.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a Servicor to update.");
                }

                string FN = txtFirstName.Text.Trim();
                string MN = txtMiddleName.Text.Trim();
                string LN = txtLastName.Text.Trim();
                string Gender = cbGender.Text.Trim();
                string Description = txtDescription.Text.Trim();
                string price = mtxtPrice.Text.Trim();
                string avail = cbAvailable.Text.Trim();
                DateTime service = dtpDataService.Value;

                servicor.UpdateServicor(dataServiceList.SelectedRows, FN, MN, LN, Gender, Description, price, avail, service);

                MessageBox.Show("Servicor has been updated.");

                LoadServicorList();

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                cbGender.SelectedIndex = -1;
                txtDescription.Clear();
                mtxtPrice.Clear();
                cbAvailable.SelectedIndex = -1;
                dtpDataService.Value = DateTime.Now;
                timeService = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataServiceList.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a Servicor to Delete.");
                }

                string FN = txtFirstName.Text.Trim();
                string MN = txtMiddleName.Text.Trim();
                string LN = txtLastName.Text.Trim();
                string Description = txtDescription.Text.Trim();

                servicor.DeleteServicor(dataServiceList.SelectedRows);

                MessageBox.Show("Servicor information Deleted successfully.");

                LoadServicorList();

                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                cbGender.SelectedIndex = -1;
                txtDescription.Clear();
                mtxtPrice.Clear();
                cbAvailable.SelectedIndex = -1;
                dtpDataService.Value = DateTime.Now;
                timeService = true;
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
            cbGender.SelectedIndex = -1;
            txtDescription.Clear();
            mtxtPrice.Clear();
            cbAvailable.SelectedIndex = -1;
            dtpDataService.Value = DateTime.Now;
            timeService = true;
            dtpDataService.Enabled = true;
        }

        private void dataServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timeService = false;

            if (e.RowIndex >= 0 && e.RowIndex < dataServiceList.Rows.Count)
            {
                DataGridViewRow selectedRow = dataServiceList.Rows[e.RowIndex];
                
                txtFirstName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtMiddleName.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                txtLastName.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                cbGender.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                txtDescription.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                mtxtPrice.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                bool Availability = selectedRow.Cells[7].Value != null && (bool)selectedRow.Cells[7].Value;
                cbAvailable.Text = Availability ? "Yes" : "No";

                if (DateTime.TryParse(selectedRow.Cells[8].Value?.ToString(), out DateTime timeServ))
                {
                    dtpDataService.Value = timeServ;
                }
            }
            
            dtpDataService.Enabled = false;
        }
    }
}
