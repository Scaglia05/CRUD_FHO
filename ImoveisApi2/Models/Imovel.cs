using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using static ImoveisApi2.Models.Enums;

namespace ImoveisApi2.Models {
    public class Imovel {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Vendedor))]
        public int Id_Vendedor { get; set; }
        public string Endereco_Imovel { get; set; }
        [Precision(10, 3)]
        public Tipo_Imovel Tipo { get; set; }
        public Status_Imovel Status { get; set; }

        public decimal AreaTotal_Imovel { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
