using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Entidades
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Titulo { get; set; }
        [StringLength(300)]
        public string Descripcion { get; set; }
        public int Orden { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
