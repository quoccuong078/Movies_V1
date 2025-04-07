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
        new Episode { Title = "Tập 2", ThumbnailUrl = "https://static2.vieon.vn/vieplay-image/poster_v4/2025/01/25/pq67xnp1_660x946-quynu.png", WatchUrl = "/watch/ep2" },
        new Episode { Title = "Tập 3", ThumbnailUrl = "/images/Banner1.jpg", WatchUrl = "/watch/ep3" },
        new Episode { Title = "Tập 4", ThumbnailUrl = "/images/Banner3.jpg", WatchUrl = "/watch/ep4" },
    };
            return View(episodes); 
        }
    }
}