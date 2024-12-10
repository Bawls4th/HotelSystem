using System.Drawing.Printing;


namespace BetterCallRoomy.Forms
{
    public partial class PrintReservants : Form
    {
        public string reservationID, guest, roomNo, servicor, totalprice, roomprice, servprice;
        public DateTime? checkIn, checkOut, dateIssued;

        private Bitmap memo;

        public PrintReservants(string reservationID, string guest, string roomNo, string servicor, DateTime? checkIn, DateTime? checkOut, 
            DateTime? dateIssued, string totalprice, string roomprice, string servprice)
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
            this.roomprice = roomprice;
            this.servprice = servprice;
        }

        public void PrintBill()
        {
            lbldate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            toolTip1.SetToolTip(pbPrint, "Print");
            lblID.Text = reservationID;
            lblName.Text = guest;
            lblRoomNo.Text = roomNo;
            lblServicor.Text = servicor;

            lblCheckIn.Text = checkIn?.ToString("g") ?? "N/A";
            lblCheckOut.Text = checkOut?.ToString("g") ?? "N/A";
            lblDateIssued.Text = dateIssued?.ToString("g") ?? "N/A";

            lblTotalAmount.Text = totalprice;
            lblroomprice.Text = roomprice;
            lblservprice.Text = servprice;
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
            int x = (pagearea.Width - this.panelDocu.Width) / 2 + 90;
            int y = (pagearea.Height - this.panelDocu.Height) / 2;

            e.Graphics.DrawImage(memo, x, y);
        }

        private void PrintReservants_Load(object sender, EventArgs e)
        {
            PrintBill();
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelDocu);
        }

        private void pbPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pbPrint, "Print");
        }

    }
}
