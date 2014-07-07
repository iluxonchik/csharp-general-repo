using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVooster
{
    class Player
    {
        protected int numPlays;
        protected Video video;
        public Player(int numPlays, Video video)
        {
            if (numPlays > 0)
                this.numPlays = numPlays;
            if (video != null)
                this.video = video;
        }

        // Properties
        public int NumPlays
        {
            get { return this.numPlays; }
        }

        // Methods

        public void makeYTRequest()
        {
            for (int i = 0; i < this.numPlays; i++)
                this.video.playVideo();
        }
    }
}
