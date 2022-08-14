using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BE_azhans;
using BLL_azhans;

namespace foroshbilit
{
    public partial class addandeditpersonels : Form
    {
        public addandeditpersonels()
        {
            InitializeComponent();
        }
        static string password = string.Empty;
        string Hash = "0mid$n";
        private bool mouseDown;
        private Point lastLocation;
        CRUDpersonels_BLL bll = new CRUDpersonels_BLL();

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string Hashing(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(result, 0, result.Length);
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("اسم کارمند را وارد کنید");
                return;
            }
            if (txt_code.Text == "")
            {
                MessageBox.Show("کد ملی کارمند را وارد کنید");
                return;
            }
            if (txt_username.Text == "")
            {
                MessageBox.Show("شناسه ی کاربری کارمند را وارد کنید");
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("رمز عبور کارمند را وارد کنید");
                return;
            }
            if (txt_password.Text.Length < 4)
            {
                MessageBox.Show("رمز عبور نمیتواند کم تر از 4 کاراکتر باشد");
                return;
            }
            if (txt_name.Text != "" && txt_code.Text != "" && txt_username.Text != ""
                && txt_password.Text != "" && txt_password.Text.Length >= 4)
            {


                if (!lbl_id.Visible)
                {

                    personels p = new personels();
                    p.name = txt_name.Text;
                    p.code = txt_code.Text;
                    p.Username = txt_username.Text;
                    password = txt_password.Text;
                    p.Password = Hashing(password);
                    p.Personelstype = GetPersonelstype();
                    MessageBox.Show(bll.Create(p));
                }
                else if (lbl_id.Visible)
                {
                    int id = int.Parse(lbl_id.Text);
                    personels pnew = new personels();
                    pnew.name = txt_name.Text;
                    pnew.code = txt_code.Text;
                    pnew.Username = txt_username.Text;
                    password = txt_password.Text;
                    pnew.Password = Hashing(password);
                    pnew.Personelstype = GetPersonelstype();
                    MessageBox.Show(bll.Update(id, pnew));
                }
            }
        }

        private personels.personelstype GetPersonelstype()
        {
            if (cmb_personestype.SelectedIndex == 0)
            {
                return personels.personelstype.Admin;
            }
            else if (cmb_personestype.SelectedIndex == 1)
            {
                return personels.personelstype.Manager;
            }
            else if (cmb_personestype.SelectedIndex == 2)
            {
                return personels.personelstype.Employee;
            }
            return 0;
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_name.Text == "")
            {
                if (e.KeyChar == ' ') e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void txt_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void addandeditpersonels_Load(object sender, EventArgs e)
        {
            cbx_showpass.Checked = false;
            txt_password.PasswordChar = '*';
        }

        private void cbx_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_showpass.Checked)
            {
                txt_password.PasswordChar = '\0';
            }
            else
            {
                txt_password.PasswordChar = '*';
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
    }
}
