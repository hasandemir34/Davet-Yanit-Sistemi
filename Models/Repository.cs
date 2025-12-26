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
            guests.Add(guest);
        }
    }
}