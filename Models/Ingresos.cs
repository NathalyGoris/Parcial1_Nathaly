
using System.ComponentModel.DataAnnotations;

public class Ingresos
{

    [Key]
    public int IngresoId { get; set; }

    [Required(ErrorMessage ="La fecha del ingreso es obligatoria")]
    public string? Fecha { get; set; }

    [Required(ErrorMessage ="El concepto del ingreso es obligatorio")]
    public string? Concepto { get; set; }

    [Required(ErrorMessage ="El monto del ingreso es obligatorio")]
    public string? Monto { get; set; }    
}