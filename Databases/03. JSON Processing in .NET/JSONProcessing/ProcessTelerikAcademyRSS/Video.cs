using Newtonsoft.Json;

namespace ProcessTelerikAcademyRss
{
    public class Video
    {
        [JsonProperty("yt:videoId")]
        public string VideoId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}