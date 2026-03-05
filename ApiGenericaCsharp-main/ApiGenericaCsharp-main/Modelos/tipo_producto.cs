using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("tipo_producto")]

public class tipo_producto
{
    [Key]
    public int id {get;set;}
    public string categoria {get;set;}
    public string clase {get;set;}
    public string nombre {get;set;}
    public string tipologia {get;set;}

}