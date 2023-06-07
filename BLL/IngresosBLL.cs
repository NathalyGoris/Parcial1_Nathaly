using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public class IngresosBLL{
    private Context _context;

    public IngresosBLL(Context context)
    {
        _context = context;
    }

    public bool Existe(int IngresoId)
    {
        return _context.Ingresos.Any(o => o.IngresoId == IngresoId);
    }

    private bool Insertar(Ingresos 	Ingresos)
    {
        _context.Ingresos.Add(Ingresos);
        return _context.SaveChanges() > 0;
    }

    private bool Modificar(Ingresos Ingresos)
    {
        var existe = _context.Ingresos.Find(Ingresos.IngresoId);
        if(existe != null)
        {
            _context.Entry(existe).CurrentValues.SetValues(Ingresos);
            return _context.SaveChanges() > 0;
        }

        return false;
    }

    public bool Guardar(Ingresos Ingresos){
        if(!Existe(Ingresos.IngresoId))
            return this.Insertar(Ingresos);
        else
            return this.Modificar(Ingresos);
    }

    public bool Eliminar(int IngresosId)
    {
        var eliminado  = _context.Ingresos.Where(o=> o.IngresoId== IngresosId).SingleOrDefault();

        if(eliminado!=null){
            _context.Entry(eliminado).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }
        return false;
    }

    public Ingresos? Buscar(int IngresoId)
    {
        return _context.Ingresos.Where(o => o.IngresoId == IngresoId).AsNoTracking().SingleOrDefault();
    }

    public List<Ingresos> GetList(Expression<Func<Ingresos, bool>> criterio)
    {
        return _context.Ingresos.AsNoTracking().Where(criterio).ToList();
    }     
}