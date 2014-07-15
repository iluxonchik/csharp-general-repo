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

            int userNumViews = int.Parse(txtNumViews.Text);
            int numThreads = int.Parse(txtNumThreads.Text);

            // First let's deliver the remainder of int division
            int remainder = userNumViews % numThreads;
            for (int i = 0; i < remainder; i++)
                video.playVideo();

            // This player is used in each one of the threads
            Player newPlayer = new Player(userNumViews/ numThreads, video);

            // Now, let's distribute the rest of the views through X threads
            for (int i = 0; i < numThreads; i++)
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
