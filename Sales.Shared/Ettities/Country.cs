using System.ComponentModel.DataAnnotations;

namespace Sales.Shared.Ettities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "Pais")]
        [Required(ErrorMessage = "Este campo {0} es Obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!;


    }
}

