
using System.ComponentModel.DataAnnotations;

public class Ingresos
{

    [Key]
    public int IngresoId { get; set; }
    public string? Fecha { get; set; }
    public string? Concepto { get; set; }
    public string? Monto { get; set; }    
}