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
    public partial class personelsCRud : Form
    {
        public personelsCRud()
        {
            InitializeComponent();
        }
        static string password = string.Empty;
        string Hash = "0mid$n";
        CRUDpersonels_BLL bll = new CRUDpersonels_BLL();


        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            addandeditpersonels frm = new addandeditpersonels();
            frm.ShowDialog();
            Statuscomboboxchanged();
        }
        private string DeHashing(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(result);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_personels.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_personels.SelectedRows != null && dgv_personels.SelectedRows.Count > 0)
            {

                addandeditpersonels frm = new addandeditpersonels();
                frm.lbl_text.Visible = true;
                frm.lbl_id.Visible = true;
                frm.lbl_id.Text = dgv_personels.CurrentRow.Cells[0].Value.ToString();
                frm.txt_username.Text = dgv_personels.CurrentRow.Cells[1].Value.ToString();
                frm.txt_name.Text = dgv_personels.CurrentRow.Cells[2].Value.ToString();
                frm.txt_code.Text = dgv_personels.CurrentRow.Cells[3].Value.ToString();
                frm.cmb_personestype.SelectedIndex = GetIndexOfEditCmb();
                password = dgv_personels.CurrentRow.Cells[4].Value.ToString();
                frm.txt_password.Text = DeHashing(password);
                dgv_personels.DataSource = bll.Read();
                dgv_personels.ClearSelection();

                frm.ShowDialog();
                Statuscomboboxchanged();
                DGVPersian();
            }

        }

        private int GetIndexOfEditCmb()
        {
            if(dgv_personels.CurrentRow.Cells[6].Value.ToString() == "Admin")
            {
                return 0;
            }
            else if (dgv_personels.CurrentRow.Cells[6].Value.ToString() == "Manager")
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public void DGVPersian()
        {

            dgv_personels.ClearSelection();
            dgv_personels.Columns["id"].Visible = false;
            dgv_personels.Columns["name"].HeaderText = "نام و نام خانوادگی";
            dgv_personels.Columns["code"].HeaderText = "کد ملی";
            dgv_personels.Columns["username"].HeaderText = "شناسه کاربری";
            dgv_personels.Columns["Personelstype"].HeaderText = "نوع کاربر";
            dgv_personels.Columns["IsActive"].Visible = false;
            dgv_personels.Columns["id"].Width = 100;
            dgv_personels.Columns["password"].Visible = false;


        }


        private void personelsCRud_Load(object sender, EventArgs e)
        {
            cbx_status.SelectedIndex = 0;
            PersonelsTypeOnLoad(mainform.PersonID);
            dgv_personels.DataSource = bll.Read(true);
            DGVPersian();
            dgv_personels.ClearSelection();

        }

        private void PersonelsTypeOnLoad(int PID)
        {
            if (bll.Read(PID).Personelstype == personels.personelstype.Admin)
            {
                dgv_personels.ContextMenuStrip = cms_activedeactive;
                btn_delete.Enabled = true;
                btn_new.Enabled = true;
                btn_edit.Enabled = true;
                label2.Visible = true;
                cbx_status.Visible = true;
            }
            else if (bll.Read(PID).Personelstype == personels.personelstype.Manager)
            {
                dgv_personels.ContextMenuStrip = null;
                btn_delete.Enabled = false;
                btn_new.Enabled = false;
                btn_edit.Enabled = false;
                label2.Visible = false;
                cbx_status.Visible = false;
            }
            else if (bll.Read(PID).Personelstype == personels.personelstype.Employee)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("از صفحه ورود وارد برنامه شوید");
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            dgv_personels.DataSource = bll.Read(name);
            DGVPersian();
        }

        private void txt_code_TextChanged(object sender, EventArgs e)
        {
            string code = txt_code.Text;
            dgv_personels.DataSource = bll.Readcode(code);
            DGVPersian();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_personels.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_personels.SelectedRows != null && dgv_personels.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("از حذف مطمعن هستید ؟", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_personels.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(bll.Delete(id));
                    dgv_personels.DataSource = bll.Read();
                    DGVPersian();
                    dgv_personels.ClearSelection();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
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

        private void Statuscomboboxchanged()
        {


            if (cbx_status.SelectedIndex == 2)
            {
                dgv_personels.DataSource = bll.Read();
                DGVPersian();
                dgv_personels.ClearSelection();
            }
            else if (cbx_status.SelectedIndex == 1)
            {
                dgv_personels.DataSource = bll.Read(false);
                DGVPersian();
                dgv_personels.ClearSelection();
            }
            else if (cbx_status.SelectedIndex == 0)
            {
                dgv_personels.DataSource = bll.Read(true);
                DGVPersian();
                dgv_personels.ClearSelection();
            }

        }

        private void cbx_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            Statuscomboboxchanged();
        }

        private void dgv_personels_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if ((bool)dgv_personels["IsActive", e.RowIndex].Value == false)
            {
                this.dgv_personels.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            if (dgv_personels.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_personels.SelectedRows != null && dgv_personels.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("کاربر فعال شود ؟", "Active", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_personels.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(bll.ActiveDeActive(id, true));
                    Statuscomboboxchanged();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }

        private void btn_deactive_Click(object sender, EventArgs e)
        {
            if (dgv_personels.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_personels.SelectedRows != null && dgv_personels.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("کاربر غیر فعال شود ؟", "DeActive", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_personels.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(bll.ActiveDeActive(id, false));
                    Statuscomboboxchanged();
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }
    }
}
