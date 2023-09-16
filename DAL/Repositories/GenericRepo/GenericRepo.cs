namespace Clinic.DAL;
public class GenericRepo<T> : IGenericRepo<T> where T : class
{
    private readonly ClinicContext _context;

    public GenericRepo(ClinicContext context)
    {
        _context = context;
    }

    public List<T> GetAll()
    {
       
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);  
    }


    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

