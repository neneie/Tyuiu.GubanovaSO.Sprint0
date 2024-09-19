using Tyuiu.GubanovaSO.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GubanovaSO.Sprint0.Task2.V0.Test;

public class DataServiceTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckGetMessageValid()
    {
        var name = "Софья";
        var res = DataService.GetMassage(name);


        Assert.AreEqual("Привет..., Софья", res);
    }
}