using System.Xml;
using Azure.Core.Pipeline;
using Microsoft.AspNetCore.Mvc;
using P1;


public class GunplaService : IGunplaService
{
    private readonly IGunplaRepository _repo;

    public GunplaService(IGunplaRepository repo)
    {
        _repo = repo;
    }
    public List<Gunpla>? GetAllModels()
    {
        return _repo.GetAllModels();
    }
    public List<string> GetAllModelsNames()
    {
        return _repo.GetAllModelsNames();
    }
    public Model? GetModelById(int id)
    {
        return _repo.GetModelById(id);
    }
    public Model? DeleteModelById(int id)
    {
        return _repo.DeleteModelById(id);
    }
    public List<Model>? SearchModelByName(string name)
    {
        return _repo.SearchModelByName(name);
    }
    public List<Model>? SearchModelByDesc(string desc)
    {
       return _repo.SearchModelByDesc(desc);
    }
    public List<Gunpla>? AddModel(Model model)
    {
       return _repo.AddModel(model);
    }
    public Task<Model?> EditById(int id , Model newModel)
    {
        return _repo.EditById(id, newModel);
    }


}