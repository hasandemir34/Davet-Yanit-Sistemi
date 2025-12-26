using Microsoft.AspNetCore.Mvc; 
using deneme.Models;  
using System.Linq;

namespace deneme.Controllers
{
    public class PartyController : Controller
    {
        // 1. ADIM: Formu ekrana getiren metod (GET)
        [HttpGet] 
        public IActionResult Register()
        {
            return View();
        }

        // 2. ADIM: Form gönderildiğinde çalışan metod (POST)
        [HttpPost] 
        public ActionResult Register(Guest guest)
        {
            if (ModelState.IsValid)
            {
                // ARTIK YORUM SATIRI DEĞİL!
                Repository.CreateGuest(guest);
                // Başarılıysa Thanks metoduna yönlendir
                return RedirectToAction("Thanks");
            }
            else
            {
                // Hata varsa aynı sayfada kal ve hataları göster
                return View(guest);
            }
        }
        public IActionResult GuestDetails(int id)
        {
            // Listeden, ID'si eşleşen ilk misafiri bul
            var guest = Repository.GetGuests().FirstOrDefault(g => g.Id == id);
            
            // Bulunan misafiri View'a gönder
            return View(guest);
        }

        public IActionResult List()
        {
            // Repository'den tüm listeyi çekiyoruz
            var guests = Repository.GetGuests();
    
            // Ve bu listeyi View'a paketleyip gönderiyoruz
            return View(guests);
        }

        // 3. ADIM: Başarı sayfasını görüntüleyen metod
        public IActionResult Thanks()
        {
            return View();
        }
    }
}