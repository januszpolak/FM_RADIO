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

        string url = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Wybierz stację";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            textBox1.Text = "Wybierz stację";
        }

        private void buttonRmf_Click(object sender, EventArgs e)
        {
           
            url = "http://80.48.65.98:/rmf_fm";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "RMF FM 96.0 Mhz";
        }

        private void buttonMaxx_Click(object sender, EventArgs e)
        {
            
            url = "http://217.74.72.6:/rmf_maxxx";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "RMF MAXXX 96.7 Mhz";
        }

        private void buttonKrakow_Click(object sender, EventArgs e)
        {
           
            url = "http://stream4.nadaje.com:9680/radiokrakow-s3";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "RADIO KRAKÓW 101.6 Mhz";

        }

        private void buttonMansfield_Click(object sender, EventArgs e)
        {
           
            url = "http://live.audiospace.co/mansfield1032";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "RADIO MANSFIELD 103.2 Mhz";
        }

       

        private void buttonSmooth_Click(object sender, EventArgs e)
        {
            url = "http://media-ice.musicradio.com:80/SmoothEastMidsMP3";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "RADIO SMOOTH 106.6 Mhz";
        }

        private void buttonCapital_Click(object sender, EventArgs e)
        {
            url = "http://media-ice.musicradio.com:80/CapitalNottinghamshireMP3";
            axWindowsMediaPlayer1.URL = url;
            textBox1.Text = "CAPITAL FM 106.6 Mhz";
        }
    }
}
