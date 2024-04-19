using System.Xml;
using Azure.Core.Pipeline;
using Microsoft.AspNetCore.Mvc;
using P1;

[ApiController]
[Route("api/[controller]")]
public class Controllers : ControllerBase
{

    private readonly IGunplaRepository _repo;
    private readonly IGunplaService _service;

    public Controllers(IGunplaService service,IGunplaRepository repo)
    {
        _repo = repo;
        _service = service;
    }

    [HttpGet("/all")]
    public ActionResult<List<Gunpla>>? GetAllModels()
    {
        List<Gunpla>? models =  _service.GetAllModels();
        if(models is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(models); 
        }
    }

    [HttpGet("/name")]
    public ActionResult<List<string>>? GetAllModelsNames()
    {
        List<string>? names = _service.GetAllModelsNames();

        if(names is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(names);
        }
    }

    [HttpGet("/{id}")]
    public ActionResult<Model> GetModelById(int id)
    {
        Model? model = _service.GetModelById(id);

        if(model is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(model);
        }
    }

    [HttpDelete("/delete")]
    public ActionResult<Model> DeleteModelById(int id)
    {
        Model? deleteModel = _service.DeleteModelById(id);
        if(deleteModel is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(deleteModel);
        }
    }

    [HttpGet("/search/name/{name}")]
    public ActionResult<List<Model>>? SearchModelByName(string name)
    {
        List<Model>? gunpla =_service.SearchModelByName(name);

        if(gunpla is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(gunpla);
        }
    }

    [HttpGet("/search/desc/{desc}")]
    public ActionResult<List<Model>>? SearchModelByDesc(string desc)
    {
       List<Model>? model = _service.SearchModelByDesc(desc);

        if(model is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(model);
        }
    }

    [HttpPost("/add")]
    public ActionResult<List<Gunpla>>? AddModel(Model model)
    {
       List<Gunpla>? gunpla = _service.AddModel(model);

        if(model is null)
        {
            return Problem();
        }
        else
        {
            return Ok(gunpla);
        }
    }

    [HttpPatch("/edit/{id}")]
    public async Task<ActionResult<Model>> EditById(int id , [FromBody] Model newModel)
    {
        Model? gunpla = await _service.EditById(id, newModel);

        if(gunpla is null)
        {
            return NoContent();
        }
        else
        {
            return Ok(gunpla);
        }
    }


}