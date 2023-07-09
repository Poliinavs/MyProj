namespace WebApplication1.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string shortDisc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool avaible { get; set; }
        public int categoryId { get; set; }
        public virtual Category Category { get; set; }


    }
}
