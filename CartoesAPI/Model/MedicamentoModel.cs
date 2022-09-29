using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Medicamento.Model
{
    public class MedicamentoModel
    {
        [Key]
        public int IdMedicamento { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatório")]
        [StringLength(16)]
        public string Descricao { get; set; }
        [Required(ErrorMessage ="Lote é obrigatório")]
        public string Lote { get; set; }
        [Required]
        public int MesVencimento { get; set; }
        [Required]
        public int AnoVencimento { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int Fabricante { get; set; }

    }
}
