using Microsoft.AspNetCore.Mvc;
using Core_Kitaplık.Models;

namespace Core_Kitaplık.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){Id=1,KitapAd="Satranç",Yazar="Zweig"},
                new Kitap(){Id=2,KitapAd="Dr Ox'un Deneyi",Yazar="Jules Verne" },
                new Kitap(){Id=3,KitapAd="Deli Fişek",Yazar="Vascenceulos" },
                new Kitap(){Id=4, KitapAd="Kırmızı Bisiklet",Yazar="Muzaffer izgü" },
                new Kitap(){Id=5, KitapAd="Toros Canavari",Yazar="Aziz Nesin" }
            };
            return View(ktp);
        }
    }
}
