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
    public partial class transferCU : Form
    {
        CRUDtransfers_BLL bll = new CRUDtransfers_BLL();
        CRUDpersonels_BLL Pbll = new CRUDpersonels_BLL();
        CRUDcity_BLL Citybll = new CRUDcity_BLL();
        CRUDcountry_BLL Countrybll = new CRUDcountry_BLL();

        private bool mouseDown;
        private Point lastLocation;
        bool flag = false;
        bool create;
        int transId;

        AutoCompleteStringCollection collectioncity = new AutoCompleteStringCollection();
        AutoCompleteStringCollection collectioncountry = new AutoCompleteStringCollection();

        public transferCU(bool abool)
        {
            InitializeComponent();
            Autocomplete();
            create = abool;
        }
        public transferCU(bool abool, int id)
        {
            InitializeComponent();
            Autocomplete();
            create = abool;
            transId = id;
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
        private void cmb_transfertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_transfertype.SelectedIndex == 1)
            {
                cmb_intflytype.Visible = true;
                flag = true;
                cityorcountry();
            }
            else
            {
                cmb_intflytype.Visible = false;
                flag = false;
                cityorcountry();
            }
            Autocomplete();
        }

        void Autocomplete()
        {
            if (GetTransferType() == transfer.transferttype.internationalfly)
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_money_TextChanged(object sender, EventArgs e)
        {
            if (txt_money.Text.Length > 0)
            {
                txt_money.Text = Convert.ToDouble(txt_money.Text).ToString("N0");
                txt_money.SelectionStart = txt_money.Text.Length;
            }
        }

        private void btn_sabt_Click(object sender, EventArgs e)
        {
            if(txt_Source.Text == "")
            {
                MessageBox.Show("مبداء را وارد کنید");
                return;
            }
            if (txt_Destination.Text == "")
            {
                MessageBox.Show("مقصد را وارد کنید");
                return;
            }
            if (txt_money.Text == "")
            {
                MessageBox.Show("قیمت را وارد کنید");
                return;
            }
            if (txt_Source.Text != "" && txt_Destination.Text != "" && txt_money.Text != "")
            {
                if (create)
                {
                    transfer t = new transfer();
                    t.Transferttype = GetTransferType();

                    if (cmb_transfertype.SelectedIndex == 1)
                    {
                        t.Internationalflytype = GetInternationalflytype();
                        t.Internationalflytypefarsi = GetInternationalflytypefarsi();
                    }

                    t.Goingbackandforthornot = GoAndBackOrNot();
                    if (t.Goingbackandforthornot)
                    {
                        t.Backingdatetime = dtp_backingdate.Value;
                    }

                    t.Passengertype = GetPassengertype();
                    t.Passengertypefarsi = GetPassengertypefarsi();

                    if (cmb_transfertype.SelectedIndex == 1)
                    {
                        t.sorcecountry = txt_Source.Text;
                        t.destinationcountry = txt_Destination.Text;
                    }
                    else
                    {
                        t.sorcecity = txt_Source.Text;
                        t.destinationcity = txt_Destination.Text;
                    }

                    t.Goingdatetime = dtp_goingdate.Value;
                    t.price = decimal.Parse(txt_money.Text);
                    t.IsActive = true;
                    t.personelsId = Pbll.Read(mainform.PersonID).id;

                    MessageBox.Show(bll.Create(t));
                }
                else if (!create)
                {
                    int id = transId;
                    transfer tnew = new transfer();
                    tnew.Transferttype = GetTransferType();

                    if (cmb_transfertype.SelectedIndex == 1)
                    {
                        tnew.Internationalflytype = GetInternationalflytype();
                        tnew.Internationalflytypefarsi = GetInternationalflytypefarsi();
                    }

                    tnew.Goingbackandforthornot = GoAndBackOrNot();
                    tnew.Passengertype = GetPassengertype();
                    tnew.Passengertypefarsi = GetPassengertypefarsi();

                    if (cmb_transfertype.SelectedIndex == 1)
                    {
                        tnew.sorcecountry = txt_Source.Text;
                        tnew.destinationcountry = txt_Destination.Text;
                    }
                    else
                    {
                        tnew.sorcecity = txt_Source.Text;
                        tnew.destinationcity = txt_Destination.Text;
                    }

                    tnew.Goingdatetime = dtp_goingdate.Value;
                    tnew.Backingdatetime = dtp_backingdate.Value;
                    tnew.price = decimal.Parse(txt_money.Text);

                    MessageBox.Show(bll.Update(id, tnew));
                }
            }
        }

        private transfer.transferttype GetTransferType()
        {
            if (cmb_transfertype.SelectedIndex == 0)
            {
                return transfer.transferttype.internalfly;
            }
            else if (cmb_transfertype.SelectedIndex == 1)
            {
                return transfer.transferttype.internationalfly;
            }
            else if (cmb_transfertype.SelectedIndex == 2)
            {
                return transfer.transferttype.train;
            }
            else if (cmb_transfertype.SelectedIndex == 3)
            {
                return transfer.transferttype.bus;
            }
            return 0;
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
        private string GetInternationalflytypefarsi()
        {
            if (cmb_intflytype.SelectedIndex == 0)
            {
                return "اکونومی";
            }
            else if (cmb_intflytype.SelectedIndex == 1)
            {
                return "بیزینس";
            }
            else if (cmb_intflytype.SelectedIndex == 2)
            {
                return "فرست کلاس";
            }
            return "";
        }

        private transfer.passengertype GetPassengertype()
        {
            if (cmb_passagetype.SelectedIndex == 0)
            {
                return transfer.passengertype.adult;
            }
            else if (cmb_passagetype.SelectedIndex == 1)
            {
                return transfer.passengertype.kid;
            }
            else if (cmb_passagetype.SelectedIndex == 2)
            {
                return transfer.passengertype.baby;
            }
            return 0;
        }
        private string GetPassengertypefarsi()
        {
            if (cmb_passagetype.SelectedIndex == 0)
            {
                return "بزرگسال";
            }
            else if (cmb_passagetype.SelectedIndex == 1)
            {
                return "کودک";
            }
            else if (cmb_passagetype.SelectedIndex == 2)
            {
                return "نوزاد";
            }
            return "";
        }

        private bool GoAndBackOrNot()
        {
            if (cmb_goandgoback.SelectedIndex == 0)
            {
                return false;
            }
            else if (cmb_goandgoback.SelectedIndex == 1)
            {
                return true;
            }
            return false;
        }

        private void cmb_goandgoback_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_goandgoback.SelectedIndex == 1)
            {
                lbl_backdate.Visible = true;
                dtp_backingdate.Visible = true;
            }
            else
            {
                lbl_backdate.Visible = false;
                dtp_backingdate.Visible = false;
            }
        }

        private void transferCU_Load(object sender, EventArgs e)
        {
            if (!create)
            {
                valuesonload();
            }
        }

        private void valuesonload()
        {
            cmb_transfertype.SelectedIndex = GetTypeOfTransById(transId);
            if(cmb_transfertype.SelectedIndex == 1)
            {
                cmb_intflytype.Visible = true;
                cmb_intflytype.SelectedIndex = GetTypeOfInterTypeById(transId);
                txt_Source.Text = bll.Read(transId).sorcecountry;
                txt_Destination.Text = bll.Read(transId).destinationcountry;
            }
            else
            {
                txt_Source.Text = bll.Read(transId).sorcecity;
                txt_Destination.Text = bll.Read(transId).destinationcity;
            }

            cmb_goandgoback.SelectedIndex = GetGoingBackOrNotById(transId);
            cmb_passagetype.SelectedIndex = GetPassAgeTypeById(transId);

            dtp_goingdate.Value = bll.Read(transId).Goingdatetime;

            if (bll.Read(transId).Goingbackandforthornot)
            {
                dtp_backingdate.Value = bll.Read(transId).Backingdatetime.Value;
            }

            txt_money.Text = bll.Read(transId).price.ToString();
        }

        private int GetTypeOfTransById(int id)
        {
            if(bll.Read(id).Transferttype == transfer.transferttype.internalfly)
            {
                return 0;
            }
            else if(bll.Read(id).Transferttype == transfer.transferttype.internationalfly)
            {
                return 1;
            }
            else if (bll.Read(id).Transferttype == transfer.transferttype.train)
            {
                return 2;
            }
            else if (bll.Read(id).Transferttype == transfer.transferttype.bus)
            {
                return 3;
            }
            return 0;
        }
        private int GetTypeOfInterTypeById(int id)
        {
            if (bll.Read(id).Internationalflytype == transfer.internationalflytype.echonomic)
            {
                return 0;
            }
            else if (bll.Read(id).Internationalflytype == transfer.internationalflytype.bussiness)
            {
                return 1;
            }
            else if (bll.Read(id).Internationalflytype == transfer.internationalflytype.firstclass)
            {
                return 2;
            }
            return 0;
        }

        private int GetGoingBackOrNotById(int id)
        {
            if (bll.Read(id).Goingbackandforthornot)
            {
                lbl_backdate.Visible = true;
                dtp_backingdate.Visible = true;
                return 1;
            }
            else if (bll.Read(id).Goingbackandforthornot == false)
            {
                return 0;
            }
            return 0;
        }
        private int GetPassAgeTypeById(int id)
        {
            if (bll.Read(id).Passengertype == transfer.passengertype.adult)
            {
                return 0;
            }
            else if (bll.Read(id).Passengertype == transfer.passengertype.kid)
            {
                return 1;
            }
            else if (bll.Read(id).Passengertype == transfer.passengertype.baby)
            {
                return 2;
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

        private void txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
