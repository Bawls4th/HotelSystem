using HotelBusinessLogic.HotelController;
using HotelModel.ReceptionistModel;

namespace BetterCallRoomy.Forms
{
    public partial class AddReceptionist : Form
    {
        private ReceptionistController Rep;
        public AddReceptionist()
        {
            InitializeComponent();
            Rep = new ReceptionistController();
            dataReceptionistList.CellClick += dataReceptionistList_CellContentClick;
        }

        private void LoadReceptionistList()
        {
            List<ReceptionistModel> receptionistModels = Rep.FetchAllReceptionist();
            dataReceptionistList.DataSource = receptionistModels;
        }


        private void AddReceptionist_Load(object sender, EventArgs e)
        {
            LoadReceptionistList();
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
                searchType = "Email";
            }
            else if (rbName.Checked)
            {
                searchType = "ID";
            }
            else if (rbUsername.Checked)
            {
                searchType = "Username";
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadReceptionistList();
                return;
            }

            try
            {
                List<ReceptionistModel> receptionistModels = Rep.SearchReceptionist(searchTerm, searchType);
                if (receptionistModels.Count > 0)
                {
                    dataReceptionistList.DataSource = receptionistModels;
                }
                else
                {
                    dataReceptionistList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataReceptionistList.DataSource = null;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try {
                string fn = txtFirstName.Text.Trim();
                string ln = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contactno = mtxtContacNo.Text.Trim();
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();

                ReceptionistModel receptionistModel = Rep.GetReceptionistModel(fn, ln, email, contactno, username, password);
                LoadReceptionistList();

                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                mtxtContacNo.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
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
                if (dataReceptionistList.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a guest to update.");
                }

                string fn = txtFirstName.Text.Trim();
                string ln = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string contactno = mtxtContacNo.Text.Trim();
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();

                DataGridViewRow selectedRow = dataReceptionistList.SelectedRows[0];

                Rep.UpdateReceptionist(dataReceptionistList.SelectedRows, fn, ln, email, contactno, username, password);
                LoadReceptionistList();
                MessageBox.Show("Receptionist has been Updated.");

                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                mtxtContacNo.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
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
                Rep.DeleteReceptionist(dataReceptionistList.SelectedRows);
                LoadReceptionistList();
                MessageBox.Show("Receptionist has been Updated.");

                txtFirstName.Clear();
                txtLastName.Clear();
                txtEmail.Clear();
                mtxtContacNo.Clear();
                txtUserName.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            mtxtContacNo.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            dataReceptionistList.ClearSelection();
        }

        private void dataReceptionistList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataReceptionistList.Rows.Count)
            {
                DataGridViewRow selectedRow = dataReceptionistList.Rows[e.RowIndex];
                txtFirstName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                txtLastName.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                txtEmail.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                mtxtContacNo.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                txtUserName.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                txtPassword.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
