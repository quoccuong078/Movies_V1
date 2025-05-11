using Movies_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Movies_V1.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult Index()
        {
            return View();
        }

        public class Movie
        {
            public string Title { get; set; }
            public string ThumbnailUrl { get; set; }
            public string WatchUrl { get; set; }
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
        new Movie { ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
        new Movie { ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
        new Movie { ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
        new Movie { ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" }
    };

            ViewBag.RecommendedMovies = recommendedMovies;
            return View(episodes); 
        }
    }
}
//new Movie { Title = "Tập 1", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
// new Movie { Title = "Tập 2", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
// new Movie { Title = "Tập 3", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
// new Movie { Title = "Tập 4", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" },