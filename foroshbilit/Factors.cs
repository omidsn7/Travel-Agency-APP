using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_azhans;
using BLL_azhans;

namespace foroshbilit
{
    public partial class Factors : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        CRUDpersonels_BLL PersBLL = new CRUDpersonels_BLL();
        CRUDfactors_BLL FacBLL = new CRUDfactors_BLL();
        CRUDpassengers_BLL PassBLL = new CRUDpassengers_BLL();
        CRUDtransfers_BLL TransBLL = new CRUDtransfers_BLL();
        public Factors()
        {
            InitializeComponent();
        }

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void guna2Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Factors_Load(object sender, EventArgs e)
        {
            PersonelsTypeOnLoad(mainform.PersonID);
            DGVPersian();
        }
        private void PersonelsTypeOnLoad(int PID)
        {
            if (PersBLL.Read(PID).Personelstype == personels.personelstype.Admin)
            {
                dgv_factors.DataSource = FacBLL.Read();
                dgv_factors.ContextMenuStrip = cms_factormanagment;
            }
            else if (PersBLL.Read(PID).Personelstype == personels.personelstype.Manager)
            {
                dgv_factors.DataSource = FacBLL.Read();
                dgv_factors.ContextMenuStrip = cms_factormanagment;
            }
            else if (PersBLL.Read(PID).Personelstype == personels.personelstype.Employee)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("از صفحه ورود وارد برنامه شوید");
        }
        public void DGVPersian()
        {
            dgv_factors.ClearSelection();
            dgv_factors.Columns["id"].Visible = false;
            dgv_factors.Columns["FactorNum"].HeaderText = "شماره فاکتور";
            dgv_factors.Columns["MakeFactorDate"].HeaderText = "زمان صدور فاکتور";
            dgv_factors.Columns["MakeFactorDate"].DefaultCellStyle.Format = "dd/MMM/yyyy/HH/mm/ss";
            dgv_factors.Columns["personelsid"].Visible = false;
            dgv_factors.Columns["personels"].Visible = false;
            dgv_factors.Columns["passengersid"].Visible = false;
            dgv_factors.Columns["passengers"].Visible = false;
            dgv_factors.Columns["transfer"].Visible = false;
            dgv_factors.Columns["IsActive"].Visible = false;
            dgv_factors.Columns["personelname"].HeaderText = "نام کارمند ثبت کننده";
            dgv_factors.Columns["passengername"].HeaderText = "نام مسافر";
            dgv_factors.Columns["transferid"].HeaderText = "کد حمل و نقل";
        }

        private void txt_factornum_TextChanged(object sender, EventArgs e)
        {
            int facnum = int.Parse(txt_factornum.Text);
            dgv_factors.DataSource = FacBLL.Read(facnum);
            DGVPersian();
        }

        private void txt_passname_TextChanged(object sender, EventArgs e)
        {
            dgv_factors.DataSource = FacBLL.Read(txt_passname.Text);
            DGVPersian();
        }

        private void dgv_factors_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((bool)dgv_factors["IsActive", e.RowIndex].Value == false)
            {
                this.dgv_factors.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void btn_showall_Click(object sender, EventArgs e)
        {
            dgv_factors.DataSource = FacBLL.Read();
            DGVPersian();
        }

        private void btn_showdeactives_Click(object sender, EventArgs e)
        {
            dgv_factors.DataSource = FacBLL.Read(false);
            DGVPersian();
        }

        private void btn_showactives_Click(object sender, EventArgs e)
        {
            dgv_factors.DataSource = FacBLL.Read(true);
            DGVPersian();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_factors.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_factors.SelectedRows != null && dgv_factors.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("فاکتور غیر فعال شود ؟", "DeActive", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_factors.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(FacBLL.ActiveDeActive(id, false));
                    dgv_factors.DataSource = FacBLL.Read(false);
                    DGVPersian();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }

        private void btn_factordetail_Click(object sender, EventArgs e)
        {
            if (dgv_factors.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_factors.SelectedRows != null && dgv_factors.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgv_factors.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show(
                                "شماره ی فاکتور : " + FacBLL.ReadId(id).FactorNum.ToString() + "\n" +
                                "\n" + "نام مسافر : " + FacBLL.ReadId(id).passengername + "\n" + "\n" +
                                "نام کارمند ثبت کننده : " + FacBLL.ReadId(id).personelname + "\n" + "\n" +
                                "کد سفر : " + FacBLL.ReadId(id).transferid.ToString() + "\n" + "\n" +
                                "نوع سفر : " + TransferTypeToString(TransBLL.Read(FacBLL.ReadId(id).transferid.Value).Transferttype) + "\n" + "\n" +
                                "شماره ی مسافر : " + PassBLL.Read(FacBLL.ReadId(id).passengersid.Value).Phone + "\n" + "\n" +
                                "قیمت : " + TransBLL.Read(FacBLL.ReadId(id).transferid.Value).price.ToString("N0") + "\n" + "\n" +
                                 "تاریخ رفت : " + TransBLL.Read(FacBLL.ReadId(id).transferid.Value).Goingdatetime.ToString("dd/MMM/yyyy") + "\n" + "\n" +
                                "تاریخ برگشت : " + TransBLL.Read(FacBLL.ReadId(id).transferid.Value).Backingdatetime?.ToString("dd/MMM/yyyy") + "\n" + "\n" +
                                "مبداء : " + GetCityorCountrySourceName(id) + "\n" + "\n" +
                                 "مقصد : " + GetCityorCountryDestinationName(id) + "\n" + "\n"
                                 , "مشخصات حمل و نقل", MessageBoxButtons.OK, MessageBoxIcon.Information
                                 , MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }
        private string GetCityorCountrySourceName(int id)
        {
            if (TransBLL.Read(FacBLL.ReadId(id).transferid.Value).Transferttype == transfer.transferttype.internationalfly)
            {
                return TransBLL.Read(FacBLL.ReadId(id).transferid.Value).sorcecountry;
            }
            else
            {
                return TransBLL.Read(FacBLL.ReadId(id).transferid.Value).sorcecity;
            }
        }
        private string GetCityorCountryDestinationName(int id)
        {
            if (TransBLL.Read(FacBLL.ReadId(id).transferid.Value).Transferttype == transfer.transferttype.internationalfly)
            {
                return TransBLL.Read(FacBLL.ReadId(id).transferid.Value).sorcecountry;
            }
            else
            {
                return TransBLL.Read(FacBLL.ReadId(id).transferid.Value).sorcecity;
            }
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
        private void btn_undelete_Click(object sender, EventArgs e)
        {
            if (dgv_factors.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_factors.SelectedRows != null && dgv_factors.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("فاکتور غیر فعال شود ؟", "DeActive", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_factors.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(FacBLL.ActiveDeActive(id, true));
                    dgv_factors.DataSource = FacBLL.Read(true);
                    DGVPersian();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }

        private void txt_factornum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_passname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_passname.Text == "")
            {
                if (e.KeyChar == ' ') e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
