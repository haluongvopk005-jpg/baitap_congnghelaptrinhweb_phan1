using Microsoft.AspNetCore.Mvc.RazorPages;
using NewsSitePortal.Models;

namespace NewsSitePortal.Pages
{
    public class IndexModel : PageModel
    {
        // Tin bài chính (hero) hiển thị to ở đầu trang
        public NewsArticle FeaturedArticle { get; private set; } = default!;

        // Hai tin bài phụ nằm hàng dưới, bên trái
        public List<NewsArticle> SecondaryArticles { get; private set; } = new();

        // Khối "Góc nhìn" bên phải
        public NewsArticle OpinionArticle { get; private set; } = default!;

        public void OnGet()
        {
            // Dữ liệu tĩnh mô phỏng nội dung trang chủ báo điện tử
            FeaturedArticle = new NewsArticle
            {
                Title = "'Ưu tiên tái định cư trước khi triển khai Trục cảnh quan sông Hồng'",
                Description = "Hà Nội sẽ ưu tiên xây dựng các khu tái định cư trước khi triển khai " +
                               "Trục Đại lộ cảnh quan sông Hồng - dự án hơn 11.400 ha, liên quan " +
                               "khoảng 247.000 dân ven sông, thực hiện giai đoạn 2026-2038.",
                ImageUrl = "https://placehold.co/900x420/2b3a4a/ffffff?text=Song+Hong+Landscape",
                TimeAgo = "1h trước",
                Category = "Thời sự"
            };

            SecondaryArticles = new List<NewsArticle>
            {
                new NewsArticle
                {
                    Title = "Hà Nội giải phóng mặt bằng cho hơn 1.400 dự án",
                    ImageUrl = "https://placehold.co/440x280/8a5a3c/ffffff?text=Giai+phong+mat+bang",
                    Category = "Thời sự"
                },
                new NewsArticle
                {
                    Title = "TP HCM siết kiểm soát người nhập cảnh phòng Ebola",
                    ImageUrl = "https://placehold.co/440x280/5c7a99/ffffff?text=San+bay",
                    Category = "Sức khỏe"
                }
            };

            OpinionArticle = new NewsArticle
            {
                Title = "'Bóc lột' trên YouTube",
                Description = "Khi cỗ máy Content ID của YouTube bị trục lợi, nhiều nghệ sĩ...",
                Author = "Hoàng Hà",
                CommentCount = 24,
                Category = "Góc nhìn"
            };
        }
    }
}
