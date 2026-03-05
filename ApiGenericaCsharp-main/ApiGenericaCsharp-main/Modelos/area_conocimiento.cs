using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiGenericaCsharp.Modelos
{
    
    [Table("area_conocimiento")]
    public class area_conocimiento
    {
        public int id { get; set; }
        public string gran_area { get; set; }
        public string area { get; set; }
        public string disciplina { get; set; }
    }
}
