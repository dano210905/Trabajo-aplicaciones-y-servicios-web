using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApiGenericaCsharp.Modelos
{
    [Table("objetivo_desarrollo_sostenible")]
    public class objetivo_desarrollo_sostenible
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }

    }
}
