/*
 *  A lot of code from this file comes from here: https://github.com/youtube/api-samples/blob/master/dotnet/UploadVideo.cs
 */
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace YTAPI
{
    class UploadVideo
    {
        // Constructors


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

        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
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
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {
            Form1 form = new Form1(); // create a reference to Form1 to be able to change its contents from this class

            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    form.UpdateStatusLabel(progress.BytesSent + "bytes sent.");
                    //Console.WriteLine("{0} bytes sent.", progress.BytesSent);
                    break;

                case UploadStatus.Failed:
                    form.UpdateStatusLabel("An error prevented the upload from completing.\n" + progress.Exception);
                    //Console.WriteLine("An error prevented the upload from completing.\n{0}", progress.Exception);
                    break;
            }
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            Console.WriteLine("Video id '{0}' was successfully uploaded.", video.Id);
        }
    }
}
