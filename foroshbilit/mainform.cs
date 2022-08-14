using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_azhans;
using BE_azhans;

namespace foroshbilit
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        public static int PersonID;
        public static int PassengerID;
        public static int TransferID;
        CRUDpersonels_BLL PBLL = new CRUDpersonels_BLL();
        CRUDpassengers_BLL PassBLL = new CRUDpassengers_BLL();
        CRUDtransfers_BLL TransBLL = new CRUDtransfers_BLL();
        CRUDfactors_BLL FactorBLL = new CRUDfactors_BLL();

        private void Form1_Load(object sender, EventArgs e)
        {
            PassengerID = 0;
            TransferID = 0;
            PersonID = int.Parse(lbl_ID.Text);
            PersonelsTypeOnLoad(PersonID);
            persian_dtp_to.Value = DateTime.Now;
        }

        private void PersonelsTypeOnLoad(int PID)
        {
            if (PBLL.Read(PID).Personelstype == personels.personelstype.Employee)
            {
                btn_personels.Enabled = false;
                btn_seefactors.Enabled = false;
            }
            else if (PBLL.Read(PID).Personelstype == personels.personelstype.Admin || PBLL.Read(PID).Personelstype == personels.personelstype.Manager)
            {
                btn_personels.Enabled = true;
                btn_seefactors.Enabled = true;
            }
            else
                MessageBox.Show("از صفحه ورود وارد برنامه شوید");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا می خواهید خارج شوید ؟", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                loginpersonels loginpersonels = new loginpersonels();
                loginpersonels.Show();
            }
        }

        private void btn_personels_Click(object sender, EventArgs e)
        {
            personelsCRud newfrm = new personelsCRud();
            newfrm.ShowDialog();
        }

        private void btn_passengers_Click(object sender, EventArgs e)
        {
            PersonID = int.Parse(lbl_ID.Text);
            selecteditpassengers pass = new selecteditpassengers();
            pass.ShowDialog();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;

        }

        private void btn_transporters_Click(object sender, EventArgs e)
        {
            PersonID = int.Parse(lbl_ID.Text);
            transferform transfer = new transferform();
            transfer.ShowDialog();

            if(TransferID != 0 && PassengerID != 0)
            {
                pbx_check.Visible = true;
            }
            else
                pbx_check.Visible = false;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            InfoAboutProgram info = new InfoAboutProgram();
            info.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (pnl_shopbag.Visible == true)
            {
                pnl_shopbag.Visible = false;
            }
            else if (pnl_shopbag.Visible == false)
            {
                pnl_shopbag.Visible = true;
                if (PassengerID == 0)
                {
                    pnl_passenger.Visible = false;
                }
                else if (PassengerID != 0)
                {
                    GetInformationOfPassenger(PassengerID);
                    pnl_passenger.Visible = true;
                    btn_delete.Enabled = true;

                    if (TransferID == 0)
                    {
                        pnl_transfer.Visible = false;
                        btn_deletepass.Visible = true;
                    }
                    if(TransferID != 0)
                    {
                        GetInformationOfTransfer(TransferID);
                        pnl_transfer.Visible = true;
                        btn_deletepass.Visible = false;
                        btn_deletetransfer.Visible = true;
                        btn_done.Enabled = true;
                    }

                }
            }
        }

        private void GetInformationOfPassenger(int PassID)
        {
            int PassengerId = PassBLL.Read(PassID).id;
            string PassengerName = PassBLL.Read(PassID).Name;
            int PassengerAge = PassBLL.Read(PassID).Age;
            string PassengerPhone = PassBLL.Read(PassID).Phone;

            lbl_passengerid.Text = PassengerId.ToString();
            lbl_passengername.Text = PassengerName;
            lbl_passengerage.Text = PassengerAge.ToString();
            lbl_passengernum.Text = PassengerPhone;

        }
        private void GetInformationOfTransfer(int TransId)
        {
            int TransferId = TransBLL.Read(TransId).id;
            string TransferType = TransferTypeToString(TransBLL.Read(TransId).Transferttype);
            string InterTransferType = TransBLL.Read(TransId).Internationalflytypefarsi;
            string TransferGoingAndBack = TransferGoingAndBackOrNot(TransBLL.Read(TransId).Goingbackandforthornot);
            string TransferAgeType = TransBLL.Read(TransId).Passengertypefarsi;
            string TransferSource = CityOrCountry(TransferType, TransId);
            string TransferDestination = CityOrCountry(TransferType, TransId);
            string TransferGoingdate = TransBLL.Read(TransId).Goingdatetime.ToString("dd/MMM/yyyy");
            string TransferBackingdate = TransBLL.Read(TransId).Backingdatetime?.ToString("dd/MMM/yyyy");
            string TransferPrice = TransBLL.Read(TransId).price.ToString("N0");

            lbl_transferid.Text = TransferId.ToString();
            lbl_transfertype.Text = TransferType;
            lbl_inttransfertype.Text = InterTransferType;
            lbl_goingandbackornot.Text = TransferGoingAndBack;
            lbl_agetype.Text = TransferAgeType;
            lbl_source.Text = TransferSource;
            lbl_destination.Text = TransferDestination;
            lbl_goingdate.Text = TransferGoingdate;
            lbl_backingdate.Text = TransferBackingdate;
            lbl_transferprice.Text = TransferPrice;
        }

        private string CityOrCountry(string Transfer, int TransId)
        {
            if (Transfer == "پرواز خارجی")
            {
                return TransBLL.Read(TransId).sorcecountry;
            }
            else
            {
                return TransBLL.Read(TransId).sorcecity;
            }
        }

        private string TransferGoingAndBackOrNot(bool abool)
        {
            if (abool)
            {
                lbl_backdate.Visible = true;
                lbl_backingdate.Visible = true;
                lbl_dash.Visible = true;
                return "رفت و برگشت";
            }
            else if (!abool)
            {
                lbl_backdate.Visible = false;
                lbl_backingdate.Visible = false;
                lbl_dash.Visible = false;
                return "رفت";
            }
            return "Error";
        }

        private string TransferTypeToString(transfer.transferttype transferttype)
        {
            if (transferttype == transfer.transferttype.internalfly)
            {
                return "پرواز داخلی";
            }
            else if (transferttype == transfer.transferttype.internationalfly)
            {
                return "پرواز خارجی";
            }
            else if (transferttype == transfer.transferttype.train)
            {
                return "قطار";
            }
            else if (transferttype == transfer.transferttype.internationalfly)
            {
                return "اتوبوس";
            }
            return "Error";
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("آیا از ثبت فاکتور اطمینان دارید ؟", "Factor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                factor f = new factor();
                Random r = new Random();
                int rint = r.Next(1000, 10000);
                f.FactorNum = rint;
                f.IsActive = true;
                f.MakeFactorDate = DateTime.Now;
                f.passengersid = PassengerID;
                f.transferid = TransferID;
                f.personelsid = PersonID;
                f.personelname = lbl_name.Text;
                f.passengername = lbl_passengername.Text;
                MessageBox.Show(FactorBLL.Create(f));
                DeleteTransferInBag();
                DeletePassengerInBag();
            }
        }

        private void btn_deletetransfer_Click(object sender, EventArgs e)
        {
            DeleteTransferInBag();
        }

        private void DeleteTransferInBag()
        {
            pnl_transfer.Visible = false;
            TransferID = 0;
            lbl_transferid.Text = "0";
            btn_done.Enabled = false;
            btn_deletepass.Visible = true;
            pbx_check.Visible = false;
        }
        private void DeletePassengerInBag()
        {
            pnl_passenger.Visible = false;
            PassengerID = 0;
            lbl_passengerid.Text = "0";
        }

        private void btn_deletepass_Click(object sender, EventArgs e)
        {
            DeletePassengerInBag();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeletePassengerInBag();
            DeleteTransferInBag();
        }

        private void btn_seefactors_Click(object sender, EventArgs e)
        {
            Factors factor = new Factors();
            factor.ShowDialog();
        }

        private void btn_selectdate_Click(object sender, EventArgs e)
        {
            if (pnl_dates.Visible)
            {
                pnl_dates.Visible = false;
            }
            else if (pnl_dates.Visible == false)
            {
                pnl_dates.Visible = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SetNumbersForMainLables(SearchEngineForPersonels());
        }

        private void SetNumbersForMainLables(int num)
        {
            string number = num.ToString();

            lbl_allpassengersforpersonels.Text = number;
            lbl_hotelreserved.Text = number;
            lbl_ticketsoled.Text = number;
        }

        private int SearchEngineForPersonels()
        {
            DateTime? dt;
            dt = perisan_dtp_from.Value;
            DateTime? dt2;
            dt2 = persian_dtp_to.Value;

            DateTime Sdt;
            DateTime Edt;

            if (dt.HasValue && dt2.HasValue)
            {
                Sdt = dt.Value;
                Edt = dt2.Value;
                return FactorBLL.Read(PersonID, Sdt, Edt);
            }
            return 0;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (pnl_dates.Visible)
            {
                pnl_dates.Visible = false;
            }
            if (pnl_shopbag.Visible == true)
            {
                pnl_shopbag.Visible = false;
            }
            lbl_allpassengersforpersonels.Text = "0";
            lbl_hotelreserved.Text = "0";
            lbl_ticketsoled.Text = "0";
        }
    }

    
}
