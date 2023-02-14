using MSTestDemo;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace MSTestProject;


[TestClass]
public class UnitTest1
{
    private readonly MSTestDemo.Program program;

    public UnitTest1()
    {
        program = new MSTestDemo.Program();
    }
    /// <summary>
    /// AAA methodology
    /// </summary>
    [TestMethod]
    [DataRow(10,20,30)]
    [DataRow(10,20,20)]
    public void TestMethod1(int first,int second,int expected)
    {
        Calculator calculator = new Calculator();
        //Act
        var actual = calculator.Addition(first, second);

        //Assert
        Assert.AreEqual(expected, actual);
    }
}