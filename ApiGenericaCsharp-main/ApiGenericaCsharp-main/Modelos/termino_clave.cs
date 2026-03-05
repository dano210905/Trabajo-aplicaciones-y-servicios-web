using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGenericaCsharp.Modelos
{
    [Table("termino_clave")]
    public class termino_clave
    {
        [Key]
        public string termino { get; set; }
        public string termino_ingles { get; set; }
    }
}
