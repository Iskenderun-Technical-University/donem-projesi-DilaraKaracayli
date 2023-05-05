using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_pansiyon
{
    public partial class FrmRadyoDinle : Form
    {
        public FrmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://85.111.3.55/";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://46.20.7.125/listen.pls";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://yayin.netyayin.net:7077/;";
        }

        private void FrmRadyoDinle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
