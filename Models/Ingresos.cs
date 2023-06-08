
using System.ComponentModel.DataAnnotations;

public class Ingresos
{

    [Key]
    public int IngresoId { get; set; }

    [Required(ErrorMessage ="La fecha del ingreso es obligatorio")]
    public DateOnly Fecha { get; set; }

    [Required(ErrorMessage ="El concepto del ingreso es obligatorio")]
    public string? Concepto { get; set; }

    [Range(1, double.MaxValue, ErrorMessage = "El valor ingresado en el monto debe ser mayor que cero.")]
    public Double Monto { get; set; }    
}