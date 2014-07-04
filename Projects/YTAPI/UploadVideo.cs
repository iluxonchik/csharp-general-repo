/*
 *  A lot of code from this file comes from here: https://github.com/youtube/api-samples/blob/master/dotnet/UploadVideo.cs
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace YTAPI
{
    class UploadVideo
    {

        // Propreties
        public string Title { set; get;}
        public string Description { set; get; }
        public string[] Tags { set; get; }
        public string CategotyId { set; get; }
        public string FilePath { set; get; }
        public string PrivacyStatus { set; get; }

        // Constructors
        public UploadVideo(string title, string description, string[] tags, string categoryId, string privacyStatus, string filePath)
        {
            Title = title;
            Description = description;
            Tags = tags;
            CategotyId = categoryId;
            PrivacyStatus = privacyStatus;
            FilePath = filePath;
        }

        public UploadVideo(string title,  string description, string[] tags, string categoryId, string filePath)
            : this(title, description, tags, categoryId, "unlisted", filePath) { } // if the privacyStatus is skipped


        public void Upload()
        {
            
            UserCredential credential;
            using (FileStream stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube, YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("YouTube.Auth.Store")).Result;
            }
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = Title;
            video.Snippet.Description = Description;
            video.Snippet.Tags = Tags;
            video.Snippet.CategoryId = CategotyId; // See https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = PrivacyStatus; // or "private" or "public"
            var filePath = FilePath; // Replace with path to actual movie file.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                const int KB = 1024;
                var minimumChunkSize = 256 * KB;

                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                // Using chunks of size 1MB
                videosInsertRequest.ChunkSize = minimumChunkSize * 4; 

                videosInsertRequest.Upload();
            }
        }


        private static void videosInsertRequest_ResponseReceived(Video obj)
        {
            Form1 form1 = (Form1)Application.OpenForms["form1"];
            form1.LabelText = "Video uploaded! ID: " + obj.Id;

        }

        private static void videosInsertRequest_ProgressChanged(IUploadProgress obj)
        {
            Form1 form1 = (Form1)Application.OpenForms["form1"];
            form1.LabelText = "Bytes sent: " + obj.BytesSent +  " , Status: "+ obj.Status + " Exception: " + obj.Exception;

        }
    }
}
