using BetterCallRoomy.ReceptionistForm;
using HotelBusinessLogic.HotelController;
using HotelModel.GuestModel;
using HotelModel.TransactionModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterCallRoomy.Forms
{
    public partial class Payment : Form
    {
        public string reservationID, guest, roomNo, servicor, totalprice;
        public DateTime? checkIn, checkOut, dateIssued;
        private const double TaxRate = 1.12;
        private TransactionController transaction;

        private bool timeRegistered = true;
        private System.Windows.Forms.Timer timecount;
        private Bitmap memo;
        private Panel overlay;
        public Payment(string reservationID, string guest, string roomNo, string servicor, DateTime? checkIn, DateTime? checkOut,
            DateTime? dateIssued, string totalprice)
        {
            InitializeComponent();
            this.reservationID = reservationID;
            this.guest = guest;
            this.roomNo = roomNo;
            this.servicor = servicor;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.dateIssued = dateIssued;
            this.totalprice = totalprice;
            txtRoomCharges.TextChanged += new System.EventHandler(txtRoomCharges_TextChanged);
            txtAmountPaid.TextChanged += new System.EventHandler(txtAmountPaid_TextChanged);
            dtpTransaction.CellClick += dtpTransaction_CellContentClick;
            transaction = new TransactionController();
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
                lblDateTime.Text = currentTime.ToString("yyyy-MM-dd HH:mm tt");
            }
        }

        private void PaymentLayout()
        {
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblID.Text = reservationID;
            lblName.Text = guest;
            lblRoomNo.Text = roomNo;
            lblServicor.Text = servicor;
            lblCheckIn.Text = checkIn?.ToString("g") ?? "N/A";
            lblCheckOut.Text = checkIn?.ToString("g") ?? "N/A";
            lblDateIssued.Text = checkOut?.ToString("g") ?? "N/A"; ;
            lblPrice.Text = totalprice;
            lblTax.Text = $"{TaxRate - 1:P}";
            lblTotal.Visible = false;
            txtRoomCharges.BorderStyle = BorderStyle.None;
            cbPaymentMethod.FlatStyle = FlatStyle.Flat;
            txtAmountPaid.BorderStyle = BorderStyle.None;
            lblChange.Visible = false;
            lblBalance.Visible = false;
            overlay = new Panel
            {
                Size = new Size(67, 28),
                Location = new Point(372, 558),
                BackColor = panelDocu.BackColor
            };

            panelDocu.Controls.Add(overlay);
            hidepan.BringToFront();

            List<TransactionModel> transactions = transaction.GetAllTransactions();
            dtpTransaction.DataSource = transactions;

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            PaymentLayout();
        }
        private void panelDocu_Paint(object sender, PaintEventArgs e)
        {
            panelDocu.BackColor = Color.Transparent;
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelDocu = pnl;
            getprintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private void getprintArea(Panel pnl)
        {
            memo = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memo, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            int x = (pagearea.Width - this.panelDocu.Width) / 2 + 75;
            int y = (pagearea.Height - this.panelDocu.Height) / 2 - 40;

            e.Graphics.DrawImage(memo, x, y);
        }

        private void pbPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbPrint, "Print");
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelDocu);
        }
        private void pbTxt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbTxt, "Text File");
        }

        private void pbTxt_Click(object sender, EventArgs e)
        {
            transaction.TextFile(dtpTransaction.SelectedRows);
        }


        private void txtRoomCharges_TextChanged(object sender, EventArgs e)
        {
            if (txtRoomCharges.ReadOnly)
            {
                return;
            }

            try
            {
                decimal price = decimal.TryParse(lblPrice.Text, out var parsedPrice) ? parsedPrice : 0;

                decimal roomCharges = decimal.TryParse(txtRoomCharges.Text, out var parsedRoomCharges) ? parsedRoomCharges : 0;

                decimal tax = 1.12m;

                if (!string.IsNullOrEmpty(txtRoomCharges.Text.Trim()))
                {
                    decimal total = (price + roomCharges) * tax;
                    lblTotal.Text = total.ToString("F2");
                    lblTotal.Visible = true;
                }
                else
                {
                    lblTotal.Text = string.Empty;
                    lblTotal.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal totalAmount = decimal.TryParse(lblTotal.Text, out var parsedTotal) ? parsedTotal : 0;
                decimal amountPaid = decimal.TryParse(txtAmountPaid.Text, out var parsedAmountPaid) ? parsedAmountPaid : 0;

                decimal change = amountPaid >= totalAmount ? amountPaid - totalAmount : 0;
                decimal balance = amountPaid < totalAmount ? totalAmount - amountPaid : 0;

                lblChange.Text = change.ToString("F2");
                lblBalance.Text = balance.ToString("F2");

                lblChange.Visible = true;
                lblBalance.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating change or balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblTotal.Text) || string.IsNullOrEmpty(txtAmountPaid.Text) || cbPaymentMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please complete all fields before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal roomCharge = 0;
                if (!decimal.TryParse(txtRoomCharges.Text, out roomCharge))
                {
                    MessageBox.Show("Invalid room charge value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal balance = 0;
                if (!decimal.TryParse(lblBalance.Text, out balance))
                {
                    MessageBox.Show("Invalid balance value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal amountPaid = 0;
                if (!decimal.TryParse(txtAmountPaid.Text, out amountPaid))
                {
                    MessageBox.Show("Invalid amount paid value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (amountPaid <= 0)
                {
                    MessageBox.Show("Amount paid must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Balance: {lblBalance.Text}, Amount Paid: {txtAmountPaid.Text}", "Transaction Details", MessageBoxButtons.OK);

                string paymentMethod = cbPaymentMethod.SelectedItem.ToString();

                TransactionModel transac = new TransactionModel
                {
                    ReservationID = int.Parse(lblID.Text),
                    RoomCharge = roomCharge,
                    Balance = balance,
                    AmountPaid = amountPaid,
                    PaymentMethod = paymentMethod
                };

                bool isSuccess = transaction.ProcessTransaction(transac);

                if (isSuccess)
                {
                    MessageBox.Show("Transaction processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpTransaction.DataSource = transaction.GetAllTransactions();
                }
                else
                {
                    MessageBox.Show("Failed to process the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dtpTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTotal.Visible = true;
            lblChange.Text = string.Empty;
            lblBalance.Text = string.Empty;

            if (e.RowIndex >= 0 && e.RowIndex < dtpTransaction.Rows.Count)
            {
                DataGridViewRow selectedRow = dtpTransaction.Rows[e.RowIndex];

                cbPaymentMethod.Text = selectedRow.Cells["PaymentMethod"].Value.ToString();

                decimal roomCharge = decimal.TryParse(selectedRow.Cells["RoomCharge"].Value.ToString(), out var parsedCharge) ? parsedCharge : 0;
                decimal balance = decimal.TryParse(selectedRow.Cells["Balance"].Value.ToString(), out var parsedBalance) ? parsedBalance : 0;

                lblTotal.Text = balance.ToString("F2");

                lblBalance.Text = balance.ToString("F2");

                txtAmountPaid.Text = string.Empty;

                txtRoomCharges.Visible = true;
                txtRoomCharges.ReadOnly = true;
                txtRoomCharges.Text = roomCharge.ToString("F2");
            }
        }
    }
}
