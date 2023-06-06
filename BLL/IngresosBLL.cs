using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class IngresosBLL
{
private Context _context;

    public IngresosBLL(Context context)
    {
        _context = context;
    }
    public bool Existe(int IngresoId)
    {
        return _context.Ingresos.Any<Ingresos>(c => c.IngresoId == IngresoId);
    }
    public bool Nuevo(Ingresos ingresos)
    {
        return true;
    }
    public bool Validar(Ingresos ingresos)
    {
        return true;
    }
    private bool Modificar(Ingresos IngresoId)
    {
        var existe = _context.Ingresos.Find(IngresoId.IngresoId);
        
        return false;
    }
    public bool Guardar(Ingresos IngresoId)
    {
         if(!Existe(IngresoId.IngresoId))
            return false;
        else
            return this.Modificar(IngresoId);
    }
    public bool Eliminar(Ingresos IngresoId)
    {
        var eliminado = _context.Ingresos.Where(o=> o.IngresoId == IngresoId);

        if(eliminado!=null){
            _context.Entry(eliminado).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
        return false;
    }
    public bool Buscar(Ingresos ingresos)
    {
        return false;
    }
    public bool Existe()
    {
      return false;  
    }

    public bool Modificar()
    {
      return false;  
    }

    public bool Insertar()
    {
      return false;  
    }   
}   