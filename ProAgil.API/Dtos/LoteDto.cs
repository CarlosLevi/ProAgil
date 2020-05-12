using System.ComponentModel.DataAnnotations;

namespace ProAgil.API.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }
        
        [Required (ErrorMessage = "Campo {0} Obrigatorio")]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Campo {0} Obrigatorio")]
        public decimal Preco { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }

        [Range (2, 120000)]
        public int Quantidade { get; set; }
    }
}