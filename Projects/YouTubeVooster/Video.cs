using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace YouTubeVooster
{
    class Video
    {
        protected string videoID;
        protected string videoToken;

        // Constructors
        public Video (string videoID, string videoToken) 
        {
            // Some error checking
            if (videoID.Length == 0)
                throw new ArgumentException("Video ID cannot be empty.", "videoID");
            else if (videoToken.Length == 0)
                throw new ArgumentException("Token cannot be empty.", "videoToken");

            // None of the arguments is an empty string, so let's go
            this.videoID = videoID;
            this.videoToken = videoToken;
               
        }
        public Video(string videoID)
        {
            // A token is not provided, so get one
            if (videoID.Length == 0)
                throw new ArgumentException("Video ID cannot be empty.", "videoID");
            this.videoID = videoID;

            // Get token from video ID.
            string newToken = Token.getToken(videoID);
            if (newToken.Length == 0)
                throw new ArgumentException("Token not found! (Invalid video ID?).", "newToken (local variable)");
            this.videoToken = newToken;
        }

        // Properties
        public string VideoID
        {
            get
            {return this.videoID; } 
            set
            {
                if (value.Length > 0)
                    this.videoID = value;
            }
        }

        public string VideoToken
        {
            get
            {return this.videoToken; }
            set
            {
                if (value.Length > 0)
                    this.videoToken = value;
            }
        }

        protected void playVideo()
        {
            /* Makes the web request, which adds a video view */

            // Build the url to wich the request will be done
            string vidURL = "https://www.youtube.com/get_video?noflv=1&video_id=" + this.videoID + "&t=" + this.videoToken;
            Uri url = new Uri(vidURL);

            // Do the request (this adds the view)
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }
    }
}
