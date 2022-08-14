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
    public partial class selecteditpassengers : Form
    {
        CRUDpassengers_BLL bll = new CRUDpassengers_BLL();
        CRUDpersonels_BLL PBLl = new CRUDpersonels_BLL();
        bool flag;
        int id;
        private bool mouseDown;
        private Point lastLocation;
        public selecteditpassengers()
        {
            InitializeComponent();
            //int persid;
            //persid = personelid;
        }

        private void selecteditpassengers_Load(object sender, EventArgs e)
        {
            dgv_passengers.DataSource = bll.ReadbypersonelsId(mainform.PersonID);
            dgv_passengers.ClearSelection();
            DGVPersian();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("اسم مسافر را وارد کنید");
                    return;
                }
                if (txt_age.Text == "")
                {
                    MessageBox.Show("سن مسافر را وارد کنید");
                    return;
                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("شماره مسافر را وارد کنید");
                    return;
                }
                if (txt_name.Text != "" && txt_age.Text != "" && txt_phone.Text != "")
                {
                    if (int.Parse(txt_age.Text) <= 120)
                    {
                        passengers p = new passengers();
                        p.Name = txt_name.Text;
                        p.Phone = txt_phone.Text;
                        p.Age = int.Parse(txt_age.Text);
                        p.IsActive = true;
                        p.personelsId = PBLl.Read(mainform.PersonID).id;
                        p.IsActive = true;
                        MessageBox.Show(bll.Create(p));
                        ClearAllText(panel2);
                        dgv_passengers.DataSource = bll.ReadbypersonelsId(mainform.PersonID);
                        DGVPersian();

                    }
                    else MessageBox.Show("حداکثر سن مسافر 120 در نظر گرفته شده است");
                }
            }
            else
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("اسم مسافر را وارد کنید");
                }
                if (txt_age.Text == "")
                {
                    MessageBox.Show("سن مسافر را وارد کنید");

                }
                if (txt_phone.Text == "")
                {
                    MessageBox.Show("شماره مسافر را وارد کنید");

                }
                if (txt_name.Text != "" && txt_age.Text != "" && txt_phone.Text != "")
                {
                    if (int.Parse(txt_age.Text) <= 120)
                    {
                        passengers pnew = new passengers();
                        pnew.Name = txt_name.Text;
                        pnew.Phone = txt_phone.Text;
                        pnew.Age = int.Parse(txt_age.Text);
                        MessageBox.Show(bll.Update(id, pnew));
                        ClearAllText(panel2);
                        dgv_passengers.DataSource = bll.ReadbypersonelsId(mainform.PersonID);
                        flag = false;
                        DGVPersian();


                    }

                    else MessageBox.Show("حداکثر سن مسافر 120 در نظر گرفته شده است");

                }
            }
        }

        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_passengers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_passengers.SelectedRows != null && dgv_passengers.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("از حذف مطمعن هستید ؟", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_passengers.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(bll.ActiveDeActive(id, false));
                    dgv_passengers.DataSource = bll.ReadbypersonelsId(mainform.PersonID);
                    dgv_passengers.ClearSelection();
                    DGVPersian();

                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }

        public void DGVPersian()
        {

            dgv_passengers.ClearSelection();
            dgv_passengers.Columns["id"].Visible = false;
            dgv_passengers.Columns["Name"].HeaderText = "نام و نام خانوادگی";
            dgv_passengers.Columns["Name"].Width = 150;
            dgv_passengers.Columns["Phone"].HeaderText = "تلفن";
            dgv_passengers.Columns["Age"].HeaderText = "سن";
            dgv_passengers.Columns["personelsId"].HeaderText = "آی دی کارمند ثبت کننده";
            dgv_passengers.Columns["personelsId"].Width = 200;
            dgv_passengers.Columns["IsActive"].Visible = false;
            dgv_passengers.Columns["personels"].Visible = false;
        }

        private void txt_namesearch_TextChanged(object sender, EventArgs e)
        {
            string name = txt_namesearch.Text;
            dgv_passengers.DataSource = bll.Read(name, mainform.PersonID);
        }

        private void txt_phonesearch_TextChanged(object sender, EventArgs e)
        {
            string phone = txt_phonesearch.Text;
            dgv_passengers.DataSource = bll.Readcode(phone, mainform.PersonID);
        }

        private void txt_agesearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_age.Text != null)
            {
                int age = int.Parse(txt_agesearch.Text);
                dgv_passengers.DataSource = bll.Readcode(age, mainform.PersonID);
            }
            else if (txt_age.Text == null)

            {
                MessageBox.Show("Test"); ;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_passengers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_passengers.SelectedRows != null && dgv_passengers.SelectedRows.Count > 0)
            {
                ClearAllText(panel2);
                id = (int)dgv_passengers.CurrentRow.Cells[0].Value;
                txt_name.Text = dgv_passengers.CurrentRow.Cells[1].Value.ToString();
                txt_phone.Text = dgv_passengers.CurrentRow.Cells[2].Value.ToString();
                txt_age.Text = dgv_passengers.CurrentRow.Cells[3].Value.ToString();
                dgv_passengers.ClearSelection();
                flag = true;
                DGVPersian();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearAllText(panel2);
            txt_name.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClearAllText(panel3);
            txt_namesearch.Focus();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.NoMove2D;
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = foroshbilit.Properties.Resources.add_90;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = foroshbilit.Properties.Resources.magnifying_glass_search__1_;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = foroshbilit.Properties.Resources.add_96;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = foroshbilit.Properties.Resources.magnifying_glass;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            if (dgv_passengers.SelectedRows.Count == 0)
            {
                MessageBox.Show("!!! لطفا یک سطر را انتخاب کنید");
            }
            else if (dgv_passengers.SelectedRows != null && dgv_passengers.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("آیا از انتخاب مسافر اطمینان دارید ؟", "Passenger", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
                if (dr == DialogResult.Yes)
                {
                    int id = int.Parse(dgv_passengers.CurrentRow.Cells[0].Value.ToString());
                    mainform.PassengerID = id;
                }
                else if (dr == DialogResult.No)
                {
                    DGVPersian();
                }
            }
        }
    }
}
