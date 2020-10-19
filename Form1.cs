using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Internetowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("RMF FM");
            listBox1.Items.Add("RMF MAXXX");
            listBox1.Items.Add("Radio Kraków");
            listBox1.Items.Add("Mansfield 103.2");
        }

        private void playRadioBtn_Click(object sender, EventArgs e)
        {
            string url = string.Empty;

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    url = "http://80.48.65.98:/rmf_fm";
                    break;
                case 1:
                    url = "http://217.74.72.6:/rmf_maxxx";
                    break;
                case 2:
                    url = "http://stream4.nadaje.com:9680/radiokrakow-s3";
                    break;
                case 3:
                    url = "http://live.audiospace.co/mansfield1032";
                    break;
                default:
                    MessageBox.Show("Wybierz stację");
                    break;
            }

            if (!url.Equals(""))
            {
                axWindowsMediaPlayer1.URL = url;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
        }
    }
}
