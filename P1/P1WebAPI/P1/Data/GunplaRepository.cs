namespace P1;

public class GunplaRepository
{
    private readonly GunplaDbContext _context;

    public GunplaRepository(GunplaDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Model> GetAllModels()
    {
        return _context.Models.ToList();
    }
}