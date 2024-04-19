using System.Text.Json.Serialization.Metadata;
using Microsoft.EntityFrameworkCore;

namespace P1;

public interface IGunplaRepository
{
    List<Gunpla> GetAllModels();


    List<string> GetAllModelsNames();


    Model? GetModelById(int id);


    Model? DeleteModelById(int id);


    List<Model> SearchModelByName(string search);


    List<Model> SearchModelByDesc(string search);



    List<Gunpla>? AddModel(Model model);

    Task<Model?> EditById(int id, Model newModel);



}