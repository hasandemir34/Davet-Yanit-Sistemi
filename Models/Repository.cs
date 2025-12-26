namespace deneme.Models
{
    public static class Repository
    {
        // Kayıtları tutacak olan statik liste
        private static List<Guest> guests = new List<Guest>();

        // Listeyi dışarıya (Controller'a) veren metod
        public static IEnumerable<Guest> GetGuests()
        {
            return guests;
        }

        // Yeni kayıt ekleyen metod
        public static void CreateGuest(Guest guest)
        {
             // Eğer liste boşsa ilk ID 1 olsun, doluysa sonuncunun ID'sine 1 ekleyelim
            if (guests.Count == 0)
            {
                guest.Id = 1;
            }
            else
            {
                // Listedeki en büyük ID'yi bul ve 1 ekle
                guest.Id = guests.Max(g => g.Id) + 1;
            }
            guests.Add(guest);
        }
    }
}