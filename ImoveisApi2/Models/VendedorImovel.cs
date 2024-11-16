using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi2.Models {
    public class VendedorImovel {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Vendedor))]
        public int Vendedor_Id { get; set; }

        [ForeignKey(nameof(Imovel))]
        public int Imovel_Id { get; set; }

    }
}
