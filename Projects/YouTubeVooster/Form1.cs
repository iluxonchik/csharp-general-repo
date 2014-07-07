using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

            // NOTE: The number of threads is hardcoded now.
            // TODO: Ask user for number of threads to use

            // Assuming that there are 20 threads
            int NUMTHREADS = 20;
            int userNumViews = int.Parse(txtNumViews.Text);
            // First let's deliver the remainder of int division
            int remainder = userNumViews % NUMTHREADS;
            for (int i = 0; i < remainder; i++)
                video.playVideo();

            // This player is used in each one of the threads
            Player newPlayer = new Player(userNumViews/ NUMTHREADS, video);

            // Now, let's distribute the rest of the views through X threads
            for (int i = 0; i < NUMTHREADS; i++)
                new Thread(new ThreadStart(newPlayer.makeYTRequest)).Start();

            /************** "Classical" approach*******************
            for (int i = 0; i < int.Parse(txtNumViews.Text); i++)
            {
                video.playVideo();
                label5.Text = i.ToString();
            }
            ******************************************************/
             
        }
    }
}
