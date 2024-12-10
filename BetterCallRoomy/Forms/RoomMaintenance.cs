using HotelBusinessLogic.HotelController;
using HotelModel.RoomModel;

namespace BetterCallRoomy.ReceptionistForm
{
    public partial class RoomMaintenance : Form
    {
        private RoomsController room;
        public RoomMaintenance()
        {
            InitializeComponent();
            room = new RoomsController();
            dataRoomList.CellClick += dataRoomList_CellContentClick;
        }

        private void RoomMaintenance_Load(object sender, EventArgs e)
        {
            LoadRoomsList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string searchType = string.Empty;

            if (rbRoomID.Checked)
            {
                searchType = "RoomID";
            }
            else if (rbRoomNo.Checked)
            {
                searchType = "RoomNo";
            }
            else if (rbRoomType.Checked)
            {
                searchType = "RoomType";
            }
            else if (rbStatus.Checked)
            {
                searchType = "Status";
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadRoomsList();
                return;
            }

            try
            {
                List<RoomModel> rooms = room.SearchRooms(searchTerm, searchType);
                if (rooms.Count > 0)
                {
                    dataRoomList.DataSource = rooms;
                }
                else
                {
                    dataRoomList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataRoomList.DataSource = null;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string roomno = cbRoomNo.Text.Trim();
                string roomtype = cbRoomType.Text.Trim();
                string floor = cbFloor.Text.Trim();
                string name = txtRoomName.Text.Trim();
                string capacity = cbCapacity.Text.Trim();
                string price = mtxtRoomPrice.Text.Trim();
                string status = cbStatus.Text.Trim();
                string availability = cbIsAvailable.Text.Trim();

                string image = pbRoom.ImageLocation;

                RoomModel roomModel = room.GetRooms(roomno, roomtype, floor, name, capacity, price, status, availability, image);

                LoadRoomsList();

                cbRoomNo.SelectedIndex = -1;
                cbRoomType.SelectedIndex = -1;
                cbFloor.SelectedIndex = -1;
                txtRoomName.Clear();
                cbCapacity.SelectedIndex = -1;
                mtxtRoomPrice.Clear();
                cbStatus.SelectedIndex = -1;
                cbIsAvailable.SelectedIndex = -1;
                pbRoom.Image = null;
                pbRoom.BackgroundImage = Properties.Resources.roomexam;
                btnUpload.Visible = true;

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
                string roomno = cbRoomNo.Text.Trim();
                string roomtype = cbRoomType.Text.Trim();
                string floor = cbFloor.Text.Trim();
                string name = txtRoomName.Text.Trim();
                string capacity = cbCapacity.Text.Trim();
                string price = mtxtRoomPrice.Text.Trim();
                string status = cbStatus.Text.Trim();
                string availability = cbIsAvailable.Text.Trim();

                room.UpdateRooms(dataRoomList.SelectedRows, roomno, roomtype, floor, name, capacity, price, status, availability);

                MessageBox.Show("Room information updated successfully.");

                LoadRoomsList();

                cbRoomNo.SelectedIndex = -1;
                cbRoomType.SelectedIndex = -1;
                cbFloor.SelectedIndex = -1;
                txtRoomName.Clear();
                cbCapacity.SelectedIndex = -1;
                mtxtRoomPrice.Clear();
                cbStatus.SelectedIndex = -1;
                cbIsAvailable.SelectedIndex = -1;
                pbRoom.Image = null;
                pbRoom.BackgroundImage = Properties.Resources.roomexam;
                btnUpload.Visible = true;
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
                if (dataRoomList.SelectedRows.Count == 0)
                {
                    throw new Exception("Please select a guest to Delete.");
                }

                DataGridViewRow selectedRow = dataRoomList.SelectedRows[0];

                string roomNo = selectedRow.Cells[1].Value?.ToString();


                bool isAvailable = cbIsAvailable.SelectedItem != null && bool.TryParse(cbIsAvailable.SelectedItem.ToString(), out bool result) && result;


                room.DeleteRooms(dataRoomList.SelectedRows, roomNo);

                LoadRoomsList();

                MessageBox.Show("Guest information Deleted successfully.");

                cbRoomNo.SelectedIndex = -1;
                cbRoomType.SelectedIndex = -1;
                cbFloor.SelectedIndex = -1;
                txtRoomName.Clear();
                cbCapacity.SelectedIndex = -1;
                mtxtRoomPrice.Clear();
                cbStatus.SelectedIndex = -1;
                cbIsAvailable.SelectedIndex = -1;
                pbRoom.Image = null;
                pbRoom.BackgroundImage = Properties.Resources.roomexam;
                btnUpload.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Select an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(selectedImagePath);

                if (IsImageAlreadyInUse(fileName))
                {
                    MessageBox.Show("The image is already in use. Please select a different image.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                pbRoom.ImageLocation = selectedImagePath;

                string imageDirectory = @"C:\Users\Julius Mendoza\source\repos\ErvinAbiadSTI\BT3102.Group7.App\BetterCallRoomy\Resources\Rooms Pictures";

                if (!Directory.Exists(imageDirectory))
                {
                    throw new Exception("Folder does not exist");
                }

                string destinationPath = Path.Combine(imageDirectory, fileName);

                pbRoom.BackgroundImage = null;
                pbRoom.Image = Image.FromFile(destinationPath);
            }
        }

        private bool IsImageAlreadyInUse(string imageFileName)
        {
            try
            {
                List<RoomModel> rooms = room.FetchAllRooms();
                foreach (var room in rooms)
                {
                    if (room.RoomPicture == imageFileName)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking image in use: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbRoomNo.SelectedIndex = -1;
            cbRoomType.SelectedIndex = -1;
            cbFloor.SelectedIndex = -1;
            txtRoomName.Clear();
            cbCapacity.SelectedIndex = -1;
            mtxtRoomPrice.Clear();
            cbStatus.SelectedIndex = -1;
            cbIsAvailable.SelectedIndex = -1;
            pbRoom.Image = Properties.Resources.roomexam;
            dataRoomList.ClearSelection();
            btnUpload.Visible = true;
        }

        private void LoadRoomsList()
        {
            List<RoomModel> rooms = room.FetchAllRooms();
            dataRoomList.DataSource = rooms;
            dataRoomList.Columns[8].ReadOnly = true;
        }

        private void dataRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpload.Visible = false;

            if (e.RowIndex >= 0 && e.RowIndex < dataRoomList.Rows.Count)
            {
                DataGridViewRow selectedRow = dataRoomList.Rows[e.RowIndex];

                cbRoomNo.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                cbRoomType.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                cbFloor.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                txtRoomName.Text = selectedRow.Cells[4].Value?.ToString() ?? string.Empty;
                cbCapacity.Text = selectedRow.Cells[5].Value?.ToString() ?? string.Empty;
                mtxtRoomPrice.Text = selectedRow.Cells[6].Value?.ToString() ?? string.Empty;
                cbStatus.Text = selectedRow.Cells[7].Value?.ToString() ?? string.Empty;

                bool isAvailable = selectedRow.Cells[8].Value != null && (bool)selectedRow.Cells[8].Value;
                cbIsAvailable.Text = isAvailable ? "Yes" : "No";

                string imageFileName = selectedRow.Cells[9].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(imageFileName))
                {
                    string imageDirectory = @"C:\Users\Julius Mendoza\source\repos\ErvinAbiadSTI\BT3102.Group7.App\BetterCallRoomy\Resources\Rooms Pictures";
                    string imagePath = Path.Combine(imageDirectory, imageFileName);

                    if (File.Exists(imagePath))
                    {
                        pbRoom.Image = Image.FromFile(imagePath);
                        pbRoom.BackgroundImage = null;
                    }
                    else
                    {
                        pbRoom.BackgroundImage = Properties.Resources.roomexam;
                    }
                }
                else
                {
                    pbRoom.BackgroundImage = Properties.Resources.roomexam;
                }
            }
            else
            {
                pbRoom.BackgroundImage = Properties.Resources.roomexam;
                MessageBox.Show("No room selected.");
            }
        }
    }
}
