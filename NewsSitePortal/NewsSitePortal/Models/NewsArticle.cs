namespace NewsSitePortal.Models
{
    // Model đại diện cho một bài báo hiển thị trên trang chủ
    public class NewsArticle
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string TimeAgo { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int CommentCount { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
