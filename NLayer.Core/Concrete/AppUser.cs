namespace NLayer.Core.Concrete
{
    public class AppUser
    {
        public string? Name { get; set; }
        public string? SurName { get; set; }

        //Yetkili ayrımının yapılması için
        public bool Authority { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public Boolean Status { get; set; }
    }
}
