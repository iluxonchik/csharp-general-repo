using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeVooster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Video video = new Video(txtVideoID.Text);
            //MessageBox.Show(video.VideoToken);


           
            for (int i = 0; i < int.Parse(txtNumViews.Text); i++)
            {
                video.playVideo();
                label5.Text = i.ToString();
            }
             
        }
    }
}
