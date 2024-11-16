using System;
using System.ComponentModel;
using System.Reflection;

namespace ImoveisApi2.Models {
    public class Enums {
        public enum Tipo_Imovel {
            [Description("Casa")]
            Casa = 1,

            [Description("Apartamento")]
            Apartamento = 2,

            [Description("Comercial")]
            Comercial = 3,

            [Description("Terreno")]
            Terreno = 4
        }

        public enum Status_Imovel {
            [Description("Disponível")]
            Disponivel = 1,

            [Description("Indisponível")]
            Indisponível = 2
        }

        // Método para obter a descrição do enum
        public static string GetEnumDescription(Enum value) {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute == null ? value.ToString() : attribute.Description;
        }
    }
}
