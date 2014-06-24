/* 
 * This is class is basically a wrapper arround some parts of the YouTube API.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Google references
using Google.GData.Client;
using Google.GData.Extensions;
using Google.GData.YouTube;
using Google.GData.Extensions.MediaRss;
using Google.YouTube;

namespace YTAPI
{
    class YTHelper
    {
        public static YouTubeRequestSettings authenticate(string appName, string devKey)
        {
            /* authenticate to be able to make API calls */
            return (new YouTubeRequestSettings(appName, devKey));
        }
       
    }
}
