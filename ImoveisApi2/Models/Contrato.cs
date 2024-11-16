using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi2.Models {
    public class Contrato {
        [Key]
        public int Id_Contrato { get; set; }


        [ForeignKey(nameof(Imovel))]
        public Imovel Id_Imovel { get; set; }

        [ForeignKey(nameof(Cliente))]
        public Cliente Id_Cliente { get; set; }



        public DateOnly Data_Inicio { get; set; }
        public DateOnly Data_Fim { get; set; }

    }
}
