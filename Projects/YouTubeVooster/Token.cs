using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YouTubeVooster
{
    static class Token
    {
        /* This is an utility class. Used to get the token associated to a video ID */
        public static string getToken(string videoID)
        {
            string vidURL = "http://youtube.com/get_video_info?video_id=" + videoID;

            Uri url = new Uri(vidURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                string responseText = reader.ReadToEnd();
                string pattern = @"&token=(.*?)&";
                Match match = Regex.Match(responseText, pattern);

                return(match.Groups[1].ToString());

            }
        }
    }
}
