namespace Knights.Models
{
    public class Knight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DragonsSlayed { get; set; }
        public bool HasSword { get; set; }

        public int CastleId { get; set; }

    }
}