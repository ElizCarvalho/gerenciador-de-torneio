using System.ComponentModel.DataAnnotations;

namespace GameManagement.MVC.Models
{
    public class TimeModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Time")]
        [Required(ErrorMessage = "Informe o nome do time.")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo são 5 caracteres.")]
        [StringLength(15, ErrorMessage = "O tamanho máximo são 15 caracteres.")]
        public string Nome { get; set; }

    }
}