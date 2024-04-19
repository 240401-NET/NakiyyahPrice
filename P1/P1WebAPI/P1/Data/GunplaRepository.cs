using System.Text.Json.Serialization.Metadata;
using Microsoft.EntityFrameworkCore;

namespace P1;

public class GunplaRepository : IGunplaRepository
{
    private readonly GunplaDbContext _context;

    public GunplaRepository(GunplaDbContext context)
    {
        _context = context;
    }

    public List<Gunpla> GetAllModels()
    {
        return _context.Database.SqlQuery<Gunpla>($"Select * From Gunpla").ToList();
    }

    public List<string> GetAllModelsNames()
    {
        return _context.Models.Select(m => m.Name).ToList();
    }

    public Model? GetModelById(int id)
    {
        return _context.Models.Find(id);
    }

    public Model? DeleteModelById(int id)
    {
        Model? model = _context.Models.Find(id);

        if(model is null)
        {
            return null;
        }
        else
        {
            _context.Models.Remove(model);
            _context.SaveChanges();
            return model;
        }
    }

    public List<Model> SearchModelByName(string search)
    {
        if(search.Trim() is null)
        {
            return null;
        } 
        else
        {
            return _context.Models.Where( m => m.Name.ToUpper().Contains(search.ToUpper().Trim())).ToList();
        }
    }
    public List<Model> SearchModelByDesc(string search)
    {
        if(search.Trim() is null)
        {
            return null;
        }
        else
        {
            return _context.Models.Where(m => m.Description.Contains(search.ToUpper().Trim())).ToList();
        }
    }

    public List<Model> SearchModelByGrade(string search)
    {
        if(search.Trim() is null || search.Trim().Length != 2) 
        {
            return null;
        }
        else
        {

            return _context.Models.Where(m => m.Description.Contains(search.Trim())).ToList();
        }
    }

    public List<Gunpla>? AddModel(Model model)
    {

        if(model.Name.Trim() is null)
        {
            return null;
        }
        else
        {
            _context.Models.Add(model);
            _context.SaveChanges();

            //var query = $"Select * From Gunpla Where id = ";

            return _context.Database.SqlQuery<Gunpla>($"Select * From Gunpla Where id ={model.Id} ").ToList();
        }

    }

    public async Task<Model?> EditById(int id, Model newModel)
    {
        Model? model = GetModelById(id);

        if(model is null)
        {
            return null;
        }
        else
        {
            model.Name = newModel.Name ?? model.Name;
            model.Grade = newModel.Grade ?? model.Grade;
            model.Type = newModel.Type ?? model.Type;
            model.Description = newModel.Description ?? model.Description;
            model.Status = newModel.Status ?? model.Status;
            await _context.SaveChangesAsync();
            return model;
        }
    }
}