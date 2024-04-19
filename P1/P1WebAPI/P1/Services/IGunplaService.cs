using System.Xml;
using Azure.Core.Pipeline;
using Microsoft.AspNetCore.Mvc;
using P1;


public interface IGunplaService
{
    List<Gunpla>? GetAllModels();
    List<string> GetAllModelsNames();
    Model? GetModelById(int id);
    Model? DeleteModelById(int id);
    List<Model>? SearchModelByName(string name);
    List<Model>? SearchModelByDesc(string desc);
    List<Gunpla>? AddModel(Model model);
    Task<Model?> EditById(int id , Model newModel);



}