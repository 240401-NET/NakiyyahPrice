using System.Data.Common;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Moq;
using P1;

namespace P1.Tests;

public class GunplaTests
{
    [Fact]
    public void GunplaServiceShouldGetAllModels()
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<Gunpla> testGunpla =
        [
            new Gunpla
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = "HG",
                Type = "Petit'G Guy",
                Status = "Unbuilt",
                Description = "Red, Small, Bear"
            }
        ];


        repoMock.Setup(repo => repo.GetAllModels()).Returns(testGunpla);
        GunplaService service = new GunplaService(repoMock.Object);


        List<Gunpla>? testGunplaList = service.GetAllModels();


        Assert.Single(testGunplaList);
    }

    [Fact]
    public void GunplaServiceShouldGetAllModelsNames()
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<string> testGunpla = ["Petit'G Guy Burning Red"];

        repoMock.Setup(repo => repo.GetAllModelsNames()).Returns(testGunpla);

        GunplaService service = new GunplaService(repoMock.Object);


        List<string> testGunplaList = service.GetAllModelsNames();


        Assert.Single(testGunplaList);
    }

    [Theory]
    [InlineData(1)]
    public void GunplaServiceShouldGetModelById(int id)
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        Model testModel =
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            };

        repoMock.Setup(repo => repo.GetModelById(id)).Returns(testModel);
        GunplaService service = new GunplaService(repoMock.Object);

        Model? model= service.GetModelById(id);

        Assert.Equal(testModel, model);

    }

    [Theory]
    [InlineData(1)]
    public void GunplaServiceShouldDeleteModelById(int id)
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        Model testModel =
        
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            };

        repoMock.Setup(repo => repo.DeleteModelById(id)).Returns(testModel);
        GunplaService service = new GunplaService(repoMock.Object);

        Model? model= service.DeleteModelById(id);

        Assert.Equal(id, model.Id);
        //Assert.Empty(repoMock.Object.testModel);

    }

    [Theory]
    [InlineData("red")]
    [InlineData("Red")]
    [InlineData(" red")]
    [InlineData("red ")]
    public void GunplaServiceShouldSearchByName(string name)
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<Model> testGunpla =
        [
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            }
        ];


        repoMock.Setup(repo => repo.SearchModelByName(name)).Returns(testGunpla);
        GunplaService service = new GunplaService(repoMock.Object);


        List<Model>? testGunplaList = service.SearchModelByName(name);


        Assert.Single(testGunplaList);
        //Assert.Contains(name, testGunplaList);
    }

    [Theory]
    [InlineData("red")]
    [InlineData("Red")]
    [InlineData(" red")]
    [InlineData("red ")]
    public void GunplaServiceShouldSearchByDesc(string desc)
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<Model> testGunpla =
        [
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            }
        ];


        repoMock.Setup(repo => repo.SearchModelByDesc(desc)).Returns(testGunpla);
        GunplaService service = new GunplaService(repoMock.Object);


        List<Model>? testGunplaList = service.SearchModelByDesc(desc);


        Assert.Single(testGunplaList);
    }

    [Fact]
    public void GunplaServiceShouldAddModel()
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        Model testModel =
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            };

        List<Gunpla> testGunpla =
        [
            new Gunpla
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = "HG",
                Type = "Petit'G Guy",
                Status = "Unbuilt",
                Description = "Red, Small, Bear"
            }
        ];

        repoMock.Setup(repo => repo.AddModel(testModel)).Returns(testGunpla);
        GunplaService service = new GunplaService(repoMock.Object);


        List<Gunpla>? testGunplaList = service.AddModel(testModel);


        Assert.Single(testGunplaList);
        Assert.Equal(testGunpla, testGunplaList);
    }

    [Theory]
    [InlineData(1, "Petit'G Guy Burning Red",1,"Petit'G Guy", 1, "Red, Small, Bear")]
    public void GunplaServiceShouldEditModelById(int id, string name, int grade, string type, int status, string description)
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        Model testModel =
            new Model
            {
                Id = id,
                Name = name,
                Grade = grade,
                Type = type,
                Status = status,
                Description = description
            };

        Model testGunpla =
        
            new Model
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = 1,
                Type = "Petit'G Guy",
                Status = 1,
                Description = "Red, Small, Bear"
            };

        repoMock.Setup(repo => repo.EditById(id,testModel)).ReturnsAsync(testGunpla);
        GunplaService service = new GunplaService(repoMock.Object);


        Task<Model?> testGunplaList = service.EditById(id, testModel);

        Assert.NotNull(testGunplaList);
    }

    [Fact]
    public void ControllerGetAllModelsReturnsType()
    {

        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<Gunpla> testGunpla =
        [
            new Gunpla
            {
                Id = 1,
                Name = "Petit'G Guy Burning Red",
                Grade = "HG",
                Type = "Petit'G Guy",
                Status = "Unbuilt",
                Description = "Red, Small, Bear"
            }
        ];

        repoMock.Setup(repo => repo.GetAllModels()).Returns(testGunpla);
        Mock<IGunplaService> mockService = new Mock<IGunplaService>();

        var Controllers = new Controllers(mockService.Object, repoMock.Object);

        var result = Controllers.GetAllModels();

        Assert.IsType<ActionResult<List<Gunpla>>?>(result);
        

    }


    [Fact]
    public void ControllerGetAllModelsNamesReturnsType()
    {
        Mock<IGunplaRepository> repoMock = new Mock<IGunplaRepository>();

        List<string> testString = new List<string>();

        repoMock.Setup(repo => repo.GetAllModelsNames()).Returns(testString);
        Mock<IGunplaService> mockService = new Mock<IGunplaService>();


        var Controllers = new Controllers(mockService.Object, repoMock.Object);
        var result = Controllers.GetAllModelsNames();
        

        Assert.IsType<ActionResult<List<string>>>(result);
        
    }
}