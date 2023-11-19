namespace ChallengeApp.Tests; 

public class EmployeeExTests
{
    [Test]
    public void GdyDodajemyOcenyPracownikowiResultaMusiDawacMaxZOcen()
    {
        //arrange
        var employee = new EmployeeEx("Adam", "Kamizelich");
        employee.AddGrades(0);
        employee.AddGrades(0);
        employee.AddGrades(0);
        // act

        var statistics = employee.GetStatistics(); 

        //assert
        Assert.AreEqual(0,statistics.Max);
    }
    [Test]
    public void GdyDodajemyOcenyPracownikowiResultaMusiDawacMinimalnaZOcen()
    {
        //arrange
        var employee = new EmployeeEx("Adam", "Kamizelich");
        employee.AddGrades(2);
        employee.AddGrades(4);
        employee.AddGrades(6);
        // act

        var statistics = employee.GetStatistics();

        //assert
        Assert.AreEqual(2, statistics.Min);
    }
    [Test]
    public void GdyDodajemyOcenyPracownikowiResultaMusiDawacSredniaOcen()
    {
        //arrange
        var employee = new EmployeeEx("Adam", "Kamizelich");
        employee.AddGrades(2);
        employee.AddGrades(0);
        employee.AddGrades(6);
        // act

        var statistics = employee.GetStatistics();

        //assert
        Assert.AreEqual((2+0+6)/3, statistics.Average);
    }

}
