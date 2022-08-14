using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_azhans;
using Microsoft.Win32;

namespace foroshbilit
{
    public partial class sqlcon : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public static string ServerName = string.Empty;
        public static string UserName = string.Empty;
        public static string Password = string.Empty;
        public static DataSet ds = new DataSet();
        public sqlcon()
        {
            InitializeComponent();
        }

        private void sqlcon_Load(object sender, EventArgs e)
        {
            cmb_server.Items.Add(".");
            cmb_server.Items.Add("(local)");
            cmb_server.Items.Add(@".\SQLEXPRESS");
            cmb_server.Items.Add(Environment.MachineName);
            cmb_server.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cmb_server.Items.Add(SetServer());
            cmb_server.SelectedIndex = 3;
        }


        public string SetServer()
        {
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        return (Environment.MachineName + @"\" + instanceName);
                    }
                }
            }
            return "";
        }

        public List<string> GetDatabaseList()
        {
            List<string> list = new List<string>();
            SqlHelper_BLL sqlHelper;

            ServerName = cmb_server.Text;
            UserName = txt_username.Text;
            Password = txt_password.Text;

            string ConString = "Data Source=" + ServerName + ";User ID=" + UserName + ";Password=" + Password + "";

            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            list.Add(dr[0].ToString());
                        }
                    }
                }

                return list;
            }
        }


        private void btn_testcon_Click(object sender, EventArgs e)
        {
            if (cmb_databases.SelectedIndex > -1)
            {
                string ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
                                                        , cmb_server.Text, cmb_databases.Text, txt_username.Text, txt_password.Text);

                try
                {
                    SqlHelper_BLL sqlHelper = new SqlHelper_BLL(ConnectionString);
                    if (sqlHelper.IsConnection())
                        MessageBox.Show("Test Connection Successed .", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("لطفا یک دیتابیس انتخاب کنید", "دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmb_databases.SelectedIndex > -1)
            {
                string ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}"
                                                       , cmb_server.Text, cmb_databases.Text, txt_username.Text, txt_password.Text);

                try
                {
                    SqlHelper_BLL sqlHelper = new SqlHelper_BLL(ConnectionString);
                    if (sqlHelper.IsConnection())
                    {
                        ConnectionStringAppCon_BLL ConStringAppCon = new ConnectionStringAppCon_BLL();
                        ConStringAppCon.SaveConnectionString("azhans", ConnectionString);
                        MessageBox.Show("Your connection string has been successfully saved", "Message",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("لطفا یک دیتابیس انتخاب کنید", "دیتابیس", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("لطفا اطلاعات را وارد کنید", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmb_databases.Enabled = true;
                cmb_databases.DataSource = GetDatabaseList();
            }
        }
    }
}
