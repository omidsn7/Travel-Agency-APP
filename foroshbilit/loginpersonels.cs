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
    public partial class loginpersonels : Form
    {
        static string password = string.Empty;
        private bool mouseDown;
        private Point lastLocation;
        string Hash = "0mid$n";
        

        public loginpersonels()
        {
            //firstTimeLog();
            InitializeComponent();
        }

        private void firstTimeLog()
        {
            personelslogin_BLL bll = new personelslogin_BLL();
            if (bll.firstLogin())
            {
                string Password = Hashing("admin");
                personels p = new personels { name = "admin", code = "1234567891", Username = "admin", IsActive = true, Personelstype = 0 };
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string Hashing(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txt_password.Text);
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            personelslogin_BLL bll = new personelslogin_BLL();
            password = txt_password.Text;

            if (bll.Login(txt_username.Text, Hashing(password)) == 1)
            {
                label1.Text = "خوش آمدید";
                mainform frm1 = new mainform();
                frm1.lbl_name.Text = bll.Read(txt_username.Text, Hashing(password)).name;
                frm1.lbl_ID.Text = bll.Read(txt_username.Text, Hashing(password)).id.ToString();
                frm1.Show();
                this.Hide();
            }

            else if (bll.Login(txt_username.Text, Hashing(password)) == 3)
            {
                label1.Text = "        اکانت شما هنوز فعال نشده است";
            }

            else if (bll.Login(txt_username.Text, txt_password.Text) == 2)
            {
                label1.Text = "نام کاربری و یا کلمه عبور اشتباه است";
                label2.Visible = true;

            }
            else if (bll.Login(txt_username.Text, txt_password.Text) == 0)
            {
                label1.Text = "اطلاعاتی در دیتابیس یافت نشد";
                label2.Visible = true;
            }

        }


        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text.Length > 0)
            {
                pictureBox2.Image = foroshbilit.Properties.Resources.icons8_sign_in_form_password_1001;
            }
            else
            {
                pictureBox2.Image = foroshbilit.Properties.Resources.icons8_sign_in_form_password_100;
            }
            if (txt_username.Text.Length > 0 && txt_password.Text.Length > 0)
            {
                btn_login.Enabled = true;
            }
            if (txt_username.Text.Length > 0 && txt_password.Text.Length > 0)
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
            }
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("لطفا با بخش آی تی تماس بگیرید");
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(txt_username.Text.Length > 0)
            {
                pictureBox1.Image = foroshbilit.Properties.Resources.icons8_username_1001;
            }
            else
            {
                pictureBox1.Image = foroshbilit.Properties.Resources.icons8_username_100;
            }
            if (txt_username.Text.Length > 0 && txt_password.Text.Length > 0)
            {
                btn_login.Enabled = true;
            }
            else
            {
                btn_login.Enabled = false;
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void txt_password_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                btn_login_Click(sender , e);
            }
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;

        }
        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            sqlcon sqlcon = new sqlcon();
            sqlcon.ShowDialog();
        }
    }
}
