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
    public ActionResult Detail()
        {
            var episodes = new List<Episode>
    {
        new Episode { Title = "Tập 1", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep1" },
        new Episode { Title = "Tập 2", ThumbnailUrl = "https://image.plo.vn/w1000/Uploaded/2025/vocgmvpi/2024_01_04/mai2-2285-4683.jpg.webp", WatchUrl = "/watch/ep2" },
        new Episode { Title = "Tập 3", ThumbnailUrl = "https://images2.thanhnien.vn/528068263637045248/2024/2/20/special-poster-2-mai-17084211313531000860296.jpg", WatchUrl = "/watch/ep3" },
        new Episode { Title = "Tập 4", ThumbnailUrl = "https://www.elle.vn/wp-content/uploads/2023/12/06/560540/poster-Mai-scaled.jpg", WatchUrl = "/watch/ep4" },
    };
            return View(episodes); 
        }
    }
}