using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImoveisApi2.Models {
    public class Vendedor {
        [Key]
        public int Id { get; set; }
        [DisplayName("Nome Vendedor")]
        public string Nome_Vendedor { get; set; }
        [DisplayName("CRECI")]
        public string CRECI_Vendedor { get; set; }

        [DisplayName("Telefone Vendedor")]
        public string Telefone_Vendedor { get; set; }

        [DisplayName("Email Vendedor")]
        public string Email_Vendedor { get; set; }
    }
}
