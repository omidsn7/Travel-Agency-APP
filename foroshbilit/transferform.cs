using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_azhans;
using BLL_azhans;

namespace foroshbilit
{
    public partial class transferform : Form
    {
        CRUDtransfers_BLL bll = new CRUDtransfers_BLL();
        CRUDpassengers_BLL Pbll = new CRUDpassengers_BLL();
        CRUDcity_BLL Citybll = new CRUDcity_BLL();
        CRUDcountry_BLL Countrybll = new CRUDcountry_BLL();

        private bool mouseDown;
        private Point lastLocation;
        bool flag = false;
        bool GoAndBackOrNot;
        string transfertype;
        AutoCompleteStringCollection collectioncity = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collectioncountry = new AutoCompleteStringCollection();

        public transferform()
        {
            InitializeComponent();
        }

        private void transfortypeclicked(string buttontext)
        {
            pnl_transfertype.Enabled = false;
            pnl_transferprops.Visible = true;
            pnl_transferprops.Enabled = true;
            btn_delete.Enabled = true;
            cityorcountry();
            lbl_transfertype.Text = buttontext;
            TransferTypeFilter(buttontext);
            pnl_transfertype.Visible = false;
            pnl_dgv.Visible = true;
            mainpicturebox.Visible = false;
            DGVPersian();
        }
        private void ChangeMainImg(string buttontext)
        {
            if (buttontext == "پرواز داخلی")
            {
                mainpicturebox.Image = foroshbilit.Properties.Resources.airplane;
            }
            else if (buttontext == "پرواز خارجی")
            {
                mainpicturebox.Image = foroshbilit.Properties.Resources.plane_s;
            }
            else if (buttontext == "قطار")
            {
                mainpicturebox.Image = foroshbilit.Properties.Resources.train;
            }
            else if (buttontext == "اتوبوس")
            {
                mainpicturebox.Image = foroshbilit.Properties.Resources.bus2;
            }

        }

        private void btn_Domesticflight_Click(object sender, EventArgs e)
        {
            transfertype = this.btn_Domesticflight.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(transfertype));
            transfortypeclicked(transfertype);

        }

        private void btn_Internationalflights_Click(object sender, EventArgs e)
        {
            transfertype = this.btn_Internationalflights.Text;
            flag = true;
            cityorcountry();
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(transfertype));
            transfortypeclicked(transfertype);
            cmb_intflytype.Visible = true;
        }

        private void btn_train_Click(object sender, EventArgs e)
        {
            transfertype = this.btn_train.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(transfertype));
            transfortypeclicked(transfertype);
        }

        private void btn_bus_Click(object sender, EventArgs e)
        {
            transfertype = this.btn_bus.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(transfertype));
            transfortypeclicked(transfertype);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BackButFunc();
        }

        private void BackButFunc()
        {
            flag = false;
            pnl_transfertype.Enabled = true;
            pnl_transferprops.Visible = false;
            pnl_transferprops.Enabled = false;
            pnl_transfertype.Visible = true;
            cmb_intflytype.Visible = false;
            pnl_dgv.Visible = false;
            mainpicturebox.Visible = true;
            cmb_onewayortwo.SelectedIndex = 0;
            txt_Source.Text = "";
            txt_Destination.Text = "";
            dtp_goingdate.Value = DateTime.Now;
            dtp_backingdate.Value = DateTime.Now;
            cmb_intflytype.SelectedIndex = 0;
            cmb_passage.SelectedItem = 0;
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void cityorcountry()
        {
            if (flag)
            {
                txt_Source.PlaceholderText = "مبداء (کشور)";
                txt_Destination.PlaceholderText = "مقصد (کشور)";
            }
            else if (!flag)
            {
                txt_Source.PlaceholderText = "مبداء (شهر)";
                txt_Destination.PlaceholderText = "مقصد (شهر)";
            }
        }

        private void transfer_Load(object sender, EventArgs e)
        {
            cmb_onewayortwo.SelectedIndex = 0;
            txt_Source.Text = "";
            txt_Destination.Text = "";
            dtp_goingdate.Value = DateTime.Now;
            dtp_backingdate.Value = DateTime.Now;
            cmb_intflytype.SelectedIndex = 0;
            cmb_passage.SelectedIndex = 0;
        }

        private void DGVPersian()
        {
            dgv_transfers.ClearSelection();
            dgv_transfers.Columns["id"].Visible = false;
            dgv_transfers.Columns["Transferttype"].Visible = false;
            dgv_transfers.Columns["Internationalflytype"].Visible = false;
            dgv_transfers.Columns["Goingbackandforthornot"].Visible = false;
            dgv_transfers.Columns["Passengertype"].Visible = false;
            dgv_transfers.Columns["IsActive"].Visible = false;

            dgv_transfers.Columns["Passengertypefarsi"].HeaderText = "رده ی سنی";
            dgv_transfers.Columns["Passengertypefarsi"].Width = 75;

            dgv_transfers.Columns["Goingdatetime"].HeaderText = "تاریخ رفت";
            dgv_transfers.Columns["Goingdatetime"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgv_transfers.Columns["Goingdatetime"].Width = 70;

            dgv_transfers.Columns["Backingdatetime"].HeaderText = "تاریخ برگشت";
            dgv_transfers.Columns["Backingdatetime"].DefaultCellStyle.Format = "dd/MMM/yyyy";
            dgv_transfers.Columns["Backingdatetime"].Width = 70;

            dgv_transfers.Columns["price"].HeaderText = "قیمت";
            dgv_transfers.Columns["price"].DefaultCellStyle.Format = "N0";
            dgv_transfers.Columns["price"].Width = 65;

            if (lbl_transfertype.Text == "پرواز خارجی")
            {
                dgv_transfers.Columns["sorcecountry"].Visible = true;
                dgv_transfers.Columns["destinationcountry"].Visible = true;
                dgv_transfers.Columns["Internationalflytypefarsi"].Visible = true;
                dgv_transfers.Columns["sorcecountry"].HeaderText = "مبداء";
                dgv_transfers.Columns["sorcecountry"].Width = 60;
                dgv_transfers.Columns["destinationcountry"].HeaderText = "مقصد";
                dgv_transfers.Columns["destinationcountry"].Width = 60;
                dgv_transfers.Columns["Internationalflytypefarsi"].HeaderText = "نوع پرواز";
                dgv_transfers.Columns["Internationalflytypefarsi"].Width = 80;
                dgv_transfers.Columns["sorcecity"].Visible = false;
                dgv_transfers.Columns["destinationcity"].Visible = false;
                dgv_transfers.Columns["Goingdatetime"].Width = 95;
                dgv_transfers.Columns["Passengertypefarsi"].Width = 80;
            }
            else
            {
                dgv_transfers.Columns["sorcecity"].Visible = true;
                dgv_transfers.Columns["destinationcity"].Visible = true;
                dgv_transfers.Columns["sorcecity"].HeaderText = "مبداء";
                dgv_transfers.Columns["sorcecity"].Width = 60;
                dgv_transfers.Columns["destinationcity"].HeaderText = "مقصد";
                dgv_transfers.Columns["destinationcity"].Width = 60;
                dgv_transfers.Columns["sorcecountry"].Visible = false;
                dgv_transfers.Columns["destinationcountry"].Visible = false;
                dgv_transfers.Columns["Internationalflytypefarsi"].Visible = false;
                dgv_transfers.Columns["Passengertypefarsi"].Width = 65;

            }

            dgv_transfers.Columns["personelsId"].Visible = false;
            dgv_transfers.Columns["personels"].Visible = false;
        }

        private transfer.transferttype TransferTypeFilter(string buttontext)
        {

            if (buttontext == "پرواز داخلی")
            {
                return transfer.transferttype.internalfly;
            }
            else if (buttontext == "پرواز خارجی")
            {
                return transfer.transferttype.internationalfly;
            }
            else if (buttontext == "قطار")
            {
                return transfer.transferttype.train;
            }
            else if (buttontext == "اتوبوس")
            {
                return transfer.transferttype.bus;
            }
            return 0;
        }

        private void cmb_onewayortwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_onewayortwo.SelectedIndex == 1)
            {
                lbl_backdate.Visible = true;
                dtp_backingdate.Visible = true;
                dtp_backingdate.Enabled = true;
            }
            else if (cmb_onewayortwo.SelectedIndex == 0)
            {
                lbl_backdate.Visible = false;
                dtp_backingdate.Visible = false;
                dtp_backingdate.Enabled = false;
            }
            string text = lbl_transfertype.Text;
            OneWayOrTwo();
            dgv_transfers.DataSource = bll.ReadByGoAndBack(TransferTypeFilter(text), OneWayOrTwo());
            DGVPersian();
        }
        private bool OneWayOrTwo()
        {
            if (cmb_onewayortwo.SelectedIndex == 1)
            {
                GoAndBackOrNot = true;
                return GoAndBackOrNot;
            }
            else if (cmb_onewayortwo.SelectedIndex == 0)
            {
                GoAndBackOrNot = false;
                return GoAndBackOrNot;
            }
            return false;
        }

        private void btn_createoredit_Click(object sender, EventArgs e)
        {
            if (dgv_transfers.SelectedRows.Count == 0)
            {
                transferCU transferCU = new transferCU(true);
                transferCU.dtp_goingdate.Value = DateTime.Now;
                transferCU.dtp_backingdate.Value = DateTime.Now;
                transferCU.ShowDialog();
                dgv_transfers.DataSource = bll.Read(TransferTypeFilter(lbl_transfertype.Text));
            }
            else if (dgv_transfers.SelectedRows != null && dgv_transfers.SelectedRows.Count > 0)
            {
                transferCU transferCU = new transferCU(false, (int)dgv_transfers.CurrentRow.Cells[0].Value);
                transferCU.ShowDialog();
                dgv_transfers.DataSource = bll.Read(TransferTypeFilter(lbl_transfertype.Text));
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Domesticflight_MouseHover(object sender, EventArgs e)
        {
            transfertype = this.btn_Domesticflight.Text;
            ChangeMainImg(transfertype);
        }

        private void btn_Internationalflights_MouseHover(object sender, EventArgs e)
        {
            transfertype = this.btn_Internationalflights.Text;
            ChangeMainImg(transfertype);
        }

        private void btn_train_MouseHover(object sender, EventArgs e)
        {
            transfertype = this.btn_train.Text;
            ChangeMainImg(transfertype);
        }

        private void btn_bus_MouseHover(object sender, EventArgs e)
        {
            transfertype = this.btn_bus.Text;
            ChangeMainImg(transfertype);
        }

        private void btn_Domesticflight_MouseLeave(object sender, EventArgs e)
        {
            mainpicturebox.Image = null;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_transfers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_transfers.SelectedRows != null && dgv_transfers.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("از حذف مطمعن هستید ؟", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_transfers.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(bll.ActiveDeActive(id, false));
                    string text = lbl_transfertype.Text;
                    dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text));
                    DGVPersian();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("از فعال کردن دوباره مطمعن هستید ؟", "Active", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (dr == DialogResult.Yes)
            {
                int id = int.Parse(dgv_transfers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show(bll.ActiveDeActive(id, true));
                dgv_transfers.DataSource = bll.Read(TransferTypeFilter(lbl_transfertype.Text));
                DGVPersian();
            }
            else if (dr == DialogResult.No)
            {
                DGVPersian();
            }
        }

        private void dgv_transfers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((bool)dgv_transfers["IsActive", e.RowIndex].Value == false)
            {
                this.dgv_transfers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void btn_transferinfo_Click(object sender, EventArgs e)
        {
            if (dgv_transfers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_transfers.SelectedRows != null && dgv_transfers.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgv_transfers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("کد حمل و نقل : " + id + "\n" + "\n" +
                                "کارمند ثبت کننده : " + Pbll.Read(bll.Read(id).personelsId).Name + "\n" +
                                "\n" + "نوع حمل و نقل : " + lbl_transfertype.Text + "\n" + "\n" +
                                "نوع پرواز : " + bll.Read(id).Internationalflytypefarsi + "\n" + "\n" +
                                "رده ی سنی : " + bll.Read(id).Passengertypefarsi + "\n" + "\n" +
                                "تاریخ رفت : " + bll.Read(id).Goingdatetime.ToString("dd/MMM/yyyy") + "\n" + "\n" +
                                "تاریخ برگشت : " + bll.Read(id).Backingdatetime?.ToString("dd/MMM/yyyy") + "\n" + "\n" +
                                "قیمت : " + bll.Read(id).price.ToString("N0") + "\n" + "\n" +
                                "مبداء : " + GetCityorCountrySourceName(id) + "\n" + "\n" +
                                 "مقصد : " + GetCityorCountryDestinationName(id) + "\n" + "\n"
                                 , "مشخصات حمل و نقل", MessageBoxButtons.OK, MessageBoxIcon.Information
                                 , MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            }
        }
        private string GetCityorCountrySourceName(int id)
        {
            if (bll.Read(id).Transferttype == transfer.transferttype.internationalfly)
            {
                return bll.Read(id).sorcecountry;
            }
            else
            {
                return bll.Read(id).sorcecity;
            }
        }
        private string GetCityorCountryDestinationName(int id)
        {
            if (bll.Read(id).Transferttype == transfer.transferttype.internationalfly)
            {
                return bll.Read(id).destinationcountry;
            }
            else
            {
                return bll.Read(id).destinationcity;
            }
        }
        private void btn_showactives_Click(object sender, EventArgs e)
        {
            string text = lbl_transfertype.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text), true);
            DGVPersian();
        }

        private void btn_showdeactive_Click(object sender, EventArgs e)
        {
            string text = lbl_transfertype.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text), false);
            DGVPersian();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string text = lbl_transfertype.Text;
            if(TransferTypeFilter(text) == transfer.transferttype.internationalfly)
            {
                bll.ReadInternational(OneWayOrTwo(), txt_Source.Text, txt_Destination.Text,
                                        dtp_goingdate.Value, dtp_backingdate.Value,
                                        GetPassengertype() , GetInternationalflytype());
            }
            else
            {
                bll.Read(TransferTypeFilter(text), OneWayOrTwo(), txt_Source.Text,
                         txt_Destination.Text, dtp_goingdate.Value, dtp_backingdate.Value,
                         GetPassengertype(), GetInternationalflytype());
            }
        }

        void Autocomplete()
        {
            string text = lbl_transfertype.Text;
            if (TransferTypeFilter(text) == transfer.transferttype.internationalfly)
            {
                txt_Source.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_Source.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_Destination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_Destination.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var countrynames = from a in Countrybll.Read() select a.Name;

                collectioncountry.AddRange(countrynames.ToArray());

                txt_Source.AutoCompleteCustomSource = collectioncountry;
                txt_Destination.AutoCompleteCustomSource = collectioncountry;
            }
            else
            {

                txt_Source.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_Source.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt_Destination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt_Destination.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var Citynames = from a in Citybll.Read() select a.Name;
                collectioncity.AddRange(Citynames.ToArray());

                txt_Source.AutoCompleteCustomSource = collectioncity;
                txt_Destination.AutoCompleteCustomSource = collectioncity;
            }
        }

        private void txt_Source_Enter(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void txt_Destination_Enter(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btn_exchange_Click(object sender, EventArgs e)
        {
            string SourceText = txt_Source.Text;
            string DestinationText = txt_Destination.Text;

            txt_Source.Text = DestinationText;
            txt_Destination.Text = SourceText;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            transfer_Load(sender , e);
            string text = lbl_transfertype.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text));
        }

        private void cmb_passage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lbl_transfertype.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text), GetPassengertype());
            DGVPersian();
        }

        private transfer.passengertype GetPassengertype()
        {
            if(cmb_passage.SelectedIndex == 0)
            {
                return transfer.passengertype.adult;
            }
            else if (cmb_passage.SelectedIndex == 1)
            {
                return transfer.passengertype.kid;
            }
            else if (cmb_passage.SelectedIndex == 2)
            {
                return transfer.passengertype.baby;
            }
            return 0;
        }

        private void cmb_intflytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lbl_transfertype.Text;
            dgv_transfers.DataSource = bll.Read(TransferTypeFilter(text), GetInternationalflytype());
            DGVPersian();
        }

        private transfer.internationalflytype GetInternationalflytype()
        {
            if (cmb_intflytype.SelectedIndex == 0)
            {
                return transfer.internationalflytype.echonomic;
            }
            else if (cmb_intflytype.SelectedIndex == 1)
            {
                return transfer.internationalflytype.bussiness;
            }
            else if (cmb_intflytype.SelectedIndex == 2)
            {
                return transfer.internationalflytype.firstclass;
            }
            return 0;
        }

        private void txt_Source_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Source.Text == "")
            {
                if (e.KeyChar == ' ') e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Destination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_Destination.Text == "")
            {
                if (e.KeyChar == ' ') e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (dgv_transfers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_transfers.SelectedRows != null && dgv_transfers.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("آیا از انتخاب سفر اطمینان دارید ؟", "Passenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_transfers.CurrentRow.Cells[0].Value.ToString());
                    mainform.TransferID = id;
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }
    }
}
