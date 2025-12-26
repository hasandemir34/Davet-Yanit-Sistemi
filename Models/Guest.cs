using System.ComponentModel.DataAnnotations;

namespace deneme.Models
{
    public class Guest
    {
        public int Id {set; get;}

        //burdaki köşeli parantez ondan sonra gelecek olana ait old. gösterir.
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [StringLength(50, ErrorMessage = "İsim 50 karakteri geçemez.")]
        public string? Name { get; set; }

        
        [Required(ErrorMessage = "Telefon numarası gereklidir.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Telefon tam 11 haneli olmalıdır.")]
        public string? Phone { get; set; }

        
        [EmailAddress(ErrorMessage = "Geçersiz e-posta formatı.")]
        public string? Email { get; set; }

        public bool WillAttend { get; set; }

    }    
}

