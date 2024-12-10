using BetterCallRoomy.CustomerForm;
using BetterCallRoomy.Forms;
using HotelBusinessLogic.HotelController;
using HotelModel.ReservationModel;

namespace BetterCallRoomy.ReceptionistForm
{
    public partial class Reservation : Form
    {
        private ReservationController reservation;
        private System.Windows.Forms.Timer timecount;
        private bool timeRegistered = true;
        public Reservation()
        {
            InitializeComponent();
            reservation = new ReservationController();
            dataReservationList.CellClick += dataReservationList_CellContentClick;
            timecount = new System.Windows.Forms.Timer();
            timecount.Interval = 1000;
            timecount.Tick += Timecount_Tick;
            timecount.Start();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string searchType = string.Empty;

            if (rbID.Checked)
            {
                searchType = "ReservationID";
            }
            else if (rbName.Checked)
            {
                searchType = "Name";
            }
            else if (rbRoom.Checked)
            {
                searchType = "RoomNo";
            }
            else if (rbServicor.Checked)
            {
                searchType = "Servicor";
            }

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadReservationList();
                return;
            }

            try
            {
                List<ReservationModel> reservationModels = reservation.SearchRooms(searchTerm, searchType);
                if (reservationModels.Count > 0)
                {
                    dataReservationList.DataSource = reservationModels;
                }
                else
                {
                    dataReservationList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataReservationList.DataSource = null;
            }

        }

        private void LoadReservationList()
        {
            List<ReservationModel> reservationModels = reservation.GetReservationInfo();
            dataReservationList.AutoGenerateColumns = false;
            dataReservationList.Columns.Clear();
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ReservationID",
                HeaderText = "Reservation-ID",
                Name = "ReservationID",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Guest",
                HeaderText = "Guest",
                Name = "Guest",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RoomNo",
                HeaderText = "Room-No",
                Name = "RoomNo",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Servicor",
                HeaderText = "Servicor",
                Name = "Servicor",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CheckIn",
                HeaderText = "Check-In",
                Name = "CheckIn",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "CheckOut",
                HeaderText = "Check-Out",
                Name = "CheckOut",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "DateIssued",
                HeaderText = "Date-Issued",
                Name = "DateIssued",
                ReadOnly = true
            });

            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "TotalPrice",
                Name = "TotalPrice",
                ReadOnly = true
            });
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RoomPrice",
                HeaderText = "RoomPrice",
                Name = "RoomPrice",
                ReadOnly = true
            });
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ServicorPrice",
                HeaderText = "ServicorPrice",
                Name = "ServicorPrice",
                ReadOnly = true
            });
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "GuestID",
                HeaderText = "GuestID",
                Name = "GuestID",
                ReadOnly = true
            });
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "RoomID",
                HeaderText = "RoomID",
                Name = "RoomID",
                ReadOnly = true
            });
            dataReservationList.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ServiceID",
                HeaderText = "ServiceID",
                Name = "ServiceID",
                ReadOnly = true
            });
            foreach (DataGridViewColumn column in dataReservationList.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            lblID.Visible = false;
            lblName.Visible = false;
            lblRoom.Visible = false;
            lblServicor.Visible = false;
            dataReservationList.DataSource = reservationModels;
            dtpIssued.Enabled = false;
            dataReservationList.Columns["RoomPrice"].Visible = false;
            dataReservationList.Columns["ServicorPrice"].Visible = false;
            dataReservationList.Columns["GuestID"].Visible = false;
            dataReservationList.Columns["RoomID"].Visible = false;
            dataReservationList.Columns["ServiceID"].Visible = false;
        }
        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadReservationList();

        }
        private void Timecount_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (timeRegistered)
            {
                dtpCheckIn.Value = new DateTime(dtpCheckIn.Value.Year, dtpCheckIn.Value.Month, dtpCheckIn.Value.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
                dtpCheckOut.Value = new DateTime(dtpCheckOut.Value.Year, dtpCheckOut.Value.Month, dtpCheckOut.Value.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
                dtpIssued.Value = new DateTime(dtpIssued.Value.Year, dtpIssued.Value.Month, dtpIssued.Value.Day, currentTime.Hour, currentTime.Minute, currentTime.Second);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string guestID = txtGuestID.Text.Trim();
                string roomID = txtRoomID.Text.Trim();
                string serviceID = txtServiceID.Text.Trim();
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                DateTime issued = dtpIssued.Value;

                ReservationModel reservationModel = reservation.GetReservationInfo(guestID, roomID, serviceID, checkIn, checkOut, issued);
                LoadReservationList();

                txtGuestID.Clear();
                txtRoomID.Clear();
                txtServiceID.Clear();
                dtpCheckIn.Value = DateTime.Now;
                dtpCheckOut.Value = DateTime.Now;
                dtpIssued.Value = DateTime.Now;
                timeRegistered = true;
                dataReservationList.ClearSelection();
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
                string guestID = txtGuestID.Text.Trim();
                string roomID = txtRoomID.Text.Trim();
                string serviceID = txtServiceID.Text.Trim();
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                DateTime issued = dtpIssued.Value;

                reservation.UpdateInfo(dataReservationList.SelectedRows, guestID, roomID, serviceID, checkIn, checkOut, issued);
                MessageBox.Show("Reservation Info has been Updated.");
                LoadReservationList();

                txtGuestID.Clear();
                txtRoomID.Clear();
                txtServiceID.Clear();
                dtpCheckIn.Value = DateTime.Now;
                dtpCheckOut.Value = DateTime.Now;
                dtpIssued.Value = DateTime.Now;
                timeRegistered = true;
                dataReservationList.ClearSelection();
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
                reservation.DeleteInfo(dataReservationList.SelectedRows);
                MessageBox.Show("Reservation Info has been Deleted.");
                LoadReservationList();

                txtGuestID.Clear();
                txtRoomID.Clear();
                txtServiceID.Clear();
                dtpCheckIn.Value = DateTime.Now;
                dtpCheckOut.Value = DateTime.Now;
                dtpIssued.Value = DateTime.Now;
                timeRegistered = true;
                dataReservationList.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestID.Clear();
            txtRoomID.Clear();
            txtServiceID.Clear();
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now;
            dtpIssued.Value = DateTime.Now;
            timeRegistered = true;
            dataReservationList.ClearSelection();
            lblID.Visible = false;
            lblName.Visible = false;
            lblRoom.Visible = false;
            lblServicor.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataReservationList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No reservation selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataGridViewRow selectedRow = dataReservationList.SelectedRows[0];

                string reservationID = selectedRow.Cells["ReservationID"].Value?.ToString() ?? string.Empty;
                string guest = selectedRow.Cells["Guest"].Value?.ToString() ?? string.Empty;
                string roomNo = selectedRow.Cells["RoomNo"].Value?.ToString() ?? string.Empty;
                string servicor = selectedRow.Cells["Servicor"].Value?.ToString() ?? string.Empty;
                DateTime? checkIn = selectedRow.Cells["CheckIn"].Value as DateTime?;
                DateTime? checkOut = selectedRow.Cells["CheckOut"].Value as DateTime?;
                DateTime? dateIssued = selectedRow.Cells["DateIssued"].Value as DateTime?;
                string totalprice = selectedRow.Cells["TotalPrice"].Value?.ToString() ?? string.Empty;
                string roomprice = selectedRow.Cells["RoomPrice"].Value?.ToString() ?? string.Empty;
                string servprice = selectedRow.Cells["ServicorPrice"].Value?.ToString() ?? string.Empty;

                PrintReservants print = new PrintReservants(reservationID, guest, roomNo, servicor, checkIn, checkOut, dateIssued, totalprice, roomprice, servprice);
                print.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataReservationList.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No reservation selected.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataGridViewRow selectedRow = dataReservationList.SelectedRows[0];
                string reservationID = selectedRow.Cells["ReservationID"].Value?.ToString() ?? string.Empty;
                string guest = selectedRow.Cells["Guest"].Value?.ToString() ?? string.Empty;
                string roomNo = selectedRow.Cells["RoomNo"].Value?.ToString() ?? string.Empty;
                string servicor = selectedRow.Cells["Servicor"].Value?.ToString() ?? string.Empty;
                DateTime? checkIn = selectedRow.Cells["CheckIn"].Value as DateTime?;
                DateTime? checkOut = selectedRow.Cells["CheckOut"].Value as DateTime?;
                DateTime? dateIssued = selectedRow.Cells["DateIssued"].Value as DateTime?;
                string totalprice = selectedRow.Cells["TotalPrice"].Value?.ToString() ?? string.Empty;

                Payment pay = new Payment(reservationID, guest, roomNo, servicor, checkIn, checkOut, dateIssued, totalprice);
                pay.ShowDialog();
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnFrmGuest_Click(object sender, EventArgs e)
        {
            GuestProfiles guestProfiles = new GuestProfiles();
            guestProfiles.Show();
        }

        private void buttonFrmRoom_Click(object sender, EventArgs e)
        {
            RoomMaintenance roomMaintenance = new RoomMaintenance();
            roomMaintenance.Show();
        }

        private void btnServicor_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }

        private void dataReservationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            timeRegistered = false;
            lblID.Visible = true;
            lblName.Visible = true;
            lblRoom.Visible = true;
            lblServicor.Visible = true;

            if (e.RowIndex >= 0 && e.RowIndex < dataReservationList.Rows.Count)
            {
                DataGridViewRow selectedRow = dataReservationList.Rows[e.RowIndex];
                txtGuestID.Text = selectedRow.Cells[10].Value?.ToString() ?? string.Empty;
                txtRoomID.Text = selectedRow.Cells[11].Value?.ToString() ?? string.Empty;
                txtServiceID.Text = selectedRow.Cells[12].Value?.ToString() ?? string.Empty;

                if (DateTime.TryParse(selectedRow.Cells[4].Value?.ToString(), out DateTime checkIn))
                {
                    dtpCheckIn.Value = checkIn;
                }

                if (DateTime.TryParse(selectedRow.Cells[5].Value?.ToString(), out DateTime checkOut))
                {
                    dtpCheckOut.Value = checkOut;
                }

                if (DateTime.TryParse(selectedRow.Cells[6].Value?.ToString(), out DateTime dateissued))
                {
                    dtpIssued.Value = dateissued;
                }

                lblName.Text = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                lblRoom.Text = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                lblServicor.Text = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;
                lblID.Text = selectedRow.Cells[0].Value?.ToString() ?? string.Empty;
            }
        }
    }
}
