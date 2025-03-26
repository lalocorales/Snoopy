using System;

namespace Snoopy.Model
{
    public class SnoopyModel
    {
        public int ID { get; set; }
        public string ?Nombre { get; set; }
        public string? Apodo { get; set; }
        public   string ?Raza { get; set; }
        public string? Dueño { get; set; }
        public string? Personalidad { get; set; }
        public DateTime? PrimeraAparicion { get; set; }
        public string? ImagenURL { get; set; }
    }
}
