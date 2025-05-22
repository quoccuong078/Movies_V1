using Movies_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Movies_V1.Controllers
{
    public class HomePageController : Controller
    {
        public class Movie
        {
            public string Title { get; set; }
            public string ThumbnailUrl { get; set; }
            public string WatchUrl { get; set; }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            var episodes = new List<Episode>
            {
                new Episode { Title = "TẬP 1", WatchUrl = "/watch/episode1" },
                new Episode { Title = "TẬP 2", WatchUrl = "/watch/episode2" },
                new Episode { Title = "TẬP 3", WatchUrl = "/watch/episode3" },
                new Episode { Title = "TẬP 4", WatchUrl = "/watch/episode4" },
                new Episode { Title = "TẬP 5", WatchUrl = "/watch/episode5" },
                new Episode { Title = "TẬP 6", WatchUrl = "/watch/episode6" },
                new Episode { Title = "TẬP 7", WatchUrl = "/watch/episode7" },
                new Episode { Title = "TẬP 8", WatchUrl = "/watch/episode8" },
                new Episode { Title = "TẬP 9", WatchUrl = "/watch/episode9" },
                new Episode { Title = "TẬP 10", WatchUrl = "/watch/episode10" },
                new Episode { Title = "TẬP 11", WatchUrl = "/watch/episode11" },
                new Episode { Title = "TẬP 12", WatchUrl = "/watch/episode12" }
            };

            var recommendedMovies = new List<Movie>
            {
                new Movie { Title = "Hòa Quang Hỗ: Bát Lãng", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
                new Movie { Title = "Long Mã Tinh Thần: Ride On 2023", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
                new Movie { Title = "Thần Thám Trấn Hộc: Detective Chen 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
                new Movie { Title = "Mục Trùng Võ Nhãn: Eye For An Eye 2022", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" },
                new Movie { Title = "Truyền Thuyết Thục: Swords Drawn 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep5" },
                new Movie { Title = "Trương Tam Phong: The Tai Chi Master 2022", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep6" },
                new Movie { Title = "Kiếm Nô Truyền Kỳ: Slave of the Sword 1993", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep7" },
                new Movie { Title = "Vũ Khí Thể Xác: Body Weapon 1999", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep8" }
            };

            ViewBag.VideoUrl = "https://vip.opstream12.com/share/f2fb9d75af8f3f2eb322ff968e62a324";
            ViewBag.MovieTitle = "Ngôi Trời Xa Sông";
            ViewBag.RecommendedMovies = recommendedMovies;

            return View(episodes);
        }

        public ActionResult Watch(string videoUrl, string movieTitle)
        {
            var episodes = new List<Episode>
            {
                new Episode { Title = "TẬP 1", WatchUrl = "/watch/episode1" },
                new Episode { Title = "TẬP 2", WatchUrl = "/watch/episode2" },
                new Episode { Title = "TẬP 3", WatchUrl = "/watch/episode3" },
                new Episode { Title = "TẬP 4", WatchUrl = "/watch/episode4" },
                new Episode { Title = "TẬP 5", WatchUrl = "/watch/episode5" },
                new Episode { Title = "TẬP 6", WatchUrl = "/watch/episode6" },
                new Episode { Title = "TẬP 7", WatchUrl = "/watch/episode7" },
                new Episode { Title = "TẬP 8", WatchUrl = "/watch/episode8" },
                new Episode { Title = "TẬP 9", WatchUrl = "/watch/episode9" },
                new Episode { Title = "TẬP 10", WatchUrl = "/watch/episode10" },
                new Episode { Title = "TẬP 11", WatchUrl = "/watch/episode11" },
                new Episode { Title = "TẬP 12", WatchUrl = "/watch/episode12" }
            };

            var recommendedMovies = new List<Movie>
            {
                new Movie { Title = "Hòa Quang Hỗ: Bát Lãng", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
                new Movie { Title = "Long Mã Tinh Thần: Ride On 2023", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
                new Movie { Title = "Thần Thám Trấn Hộc: Detective Chen 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
                new Movie { Title = "Mục Trùng Võ Nhãn: Eye For An Eye 2022", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" }
            };

            ViewBag.VideoUrl = videoUrl ?? "https://vip.opstream12.com/share/f2fb9d75af8f3f2eb322ff968e62a324";
            ViewBag.MovieTitle = movieTitle ?? "Ngôi Trời Xa Sông";
            ViewBag.Episodes = episodes;
            ViewBag.RecommendedMovies = recommendedMovies;

            return View();
        }

        public ActionResult Search(string query)
        {
            var allMovies = new List<Movie>
            {
                new Movie { Title = "Hòa Quang Hỗ: Bát Lãng", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
                new Movie { Title = "Long Mã Tinh Thần: Ride On 2023", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
                new Movie { Title = "Thần Thám Trấn Hộc: Detective Chen 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
                new Movie { Title = "Mục Trùng Võ Nhãn: Eye For An Eye 2022", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" },
                new Movie { Title = "Truyền Thuyết Thục: Swords Drawn 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep5" },
                new Movie { Title = "Trương Tam Phong: The Tai Chi Master 2022", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep6" },
                new Movie { Title = "Kiếm Nô Truyền Kỳ: Slave of the Sword 1993", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep7" },
                new Movie { Title = "Vũ Khí Thể Xác: Body Weapon 1999", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep8" }
            };

            var searchResults = string.IsNullOrEmpty(query)
                ? allMovies
                : allMovies.Where(m => m.Title.ToLower().Contains(query.ToLower())).ToList();

            ViewBag.SearchQuery = query;
            ViewBag.SearchResults = searchResults;
            return View();
        }

        public ActionResult Category(string category)
        {
            var allMovies = new List<Movie>
            {
                new Movie { Title = "Hòa Quang Hỗ: Bát Lãng", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
                new Movie { Title = "Long Mã Tinh Thần: Ride On 2023", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
                new Movie { Title = "Thần Thám Trấn Hộc: Detective Chen 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
                new Movie { Title = "Mục Trùng Võ Nhãn: Eye For An Eye 2022", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" },
                new Movie { Title = "Truyền Thuyết Thục: Swords Drawn 2022", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep5" },
                new Movie { Title = "Trương Tam Phong: The Tai Chi Master 2022", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep6" },
                new Movie { Title = "Kiếm Nô Truyền Kỳ: Slave of the Sword 1993", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep7" },
                new Movie { Title = "Vũ Khí Thể Xác: Body Weapon 1999", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep8" }
            };

            var categoryResults = allMovies;
            if (!string.IsNullOrEmpty(category))
            {
                categoryResults = allMovies.Where(m =>
                    (category == "PhimBo" && m.Title.Contains("2022")) ||
                    (category == "PhimLe" && m.Title.Contains("1993")) ||
                    (category == "ThieuNhi" && m.Title.Contains("2023")) ||
                    (category == "TheThao" && m.Title.Contains("1999"))).ToList();
            }

            ViewBag.Category = category;
            ViewBag.Movies = categoryResults;
            return View("Search");
        }

        // Action cho đăng nhập
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Email and password are required.";
                return View();
            }

            if (email == "test@example.com" && password == "123456")
            {
                FormsAuthentication.SetAuthCookie(email, false);
                // Thêm một bước để đảm bảo cookie được lưu
                Response.Cookies[FormsAuthentication.FormsCookieName].Expires = DateTime.Now.AddMinutes(2880);
                return RedirectToAction("Index");
            }

            ViewBag.Error = "Invalid login attempt.";
            return View();
        }

        // Action cho đăng ký
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(string email, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                ViewBag.Error = "All fields are required.";
                return View();
            }

            if (password != confirmPassword)
            {
                ViewBag.Error = "Passwords do not match.";
                return View();
            }

            // Giả lập đăng ký (thay bằng logic lưu vào cơ sở dữ liệu)
            FormsAuthentication.SetAuthCookie(email, false);
            return RedirectToAction("Index");
        }

        // Action cho quên mật khẩu
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ViewBag.Error = "Email is required.";
                return View();
            }

            // Giả lập gửi email reset mật khẩu (thay bằng logic thực tế)
            ViewBag.Message = "A reset link has been sent to your email.";
            return View();
        }

        // Action cho đăng xuất
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        // Action cho trang cá nhân
        public ActionResult Profile()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserName = User.Identity.Name;
                return View();
            }
            return RedirectToAction("Login");
        }
    }
}