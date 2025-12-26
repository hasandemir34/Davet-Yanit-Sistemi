using Microsoft.AspNetCore.Mvc; // Controller ve IActionResult için gerekli
using deneme.Models;  // Yazdığımız Guest modeline ulaşmak için gerekli




namespace deneme.Controllers
{
    
    public class PartyController : Controller
    {
        
        [HttpPost] //form gönderildiğinde burası çalışır
        public ActionResult Register(Guest guest)
        {

        // ModelState.IsValid: Kurallara (Required vb.) uyulmuş mu? [cite: 44]
        if (ModelState.IsValid)
        {
        // Veri doğruysa bir yere kaydet (Şimdilik geçici bir işlem gibi düşün)
        // Repository.CreateGuest(guest); 

        // Başarılıysa kullanıcıyı başka sayfaya yönlendir (PRG Deseni) [cite: 116, 118]
        return RedirectToAction("Thanks");
        }
        else
        {
        // Hata varsa aynı sayfada kal ve hataları göster [cite: 51, 128]
        return View(guest);
        }
        }
    }
    


}