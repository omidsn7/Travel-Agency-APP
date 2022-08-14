using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foroshbilit
{
    public partial class InfoAboutProgram : Form
    {
        public InfoAboutProgram()
        {
            InitializeComponent();
        }

        private void btn_instagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/om1d.sn/");
        }

        private void btn_telegram_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/om1dsn");
        }

        private void btn_whatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("https://wa.me/989212204163");
        }
    }
}
