
namespace ChallengeApp.Tests
{
    internal class Dzień12TestEmployeeHW
    {
        [Test]
        public void GdyDodajemyOcenyPracownikowiLiteraAMusiDziałaćSwitch()
        {
            //arrange
            var employee = new EmployeeEx();
            employee.AddGrades('A');
            employee.AddGrades('a');
            // act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Average);
        }
        [Test]
        public void GdyDodajemyOcenyPracownikowiLitera_bcde_MusiDziałaćSwitch()
        {
            //arrange
            var employee = new EmployeeEx();
            employee.AddGrades('b');
            employee.AddGrades('c');
            employee.AddGrades('d');
            employee.AddGrades('e');
            
            // act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(50, statistics.Average);
        }
        [Test]
        public void GdyDodajemyOcenyPracownikowiLitera_BCDE_MusiDziałaćSwitch()
        {
            //arrange
            var employee = new EmployeeEx();
            employee.AddGrades('B');
            employee.AddGrades('C');
            employee.AddGrades('D');
            employee.AddGrades('E');

            // act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(50, statistics.Average);
        }
        [Test]
        public void GdyDodajemyOcenyPracownikowiLitera_NIE_ABCDE_MusiDziałaćSwitch()
        {
            //arrange
            var employee = new EmployeeEx();
            employee.AddGrades('K');
            employee.AddGrades('o');
            employee.AddGrades('Z');
            employee.AddGrades('m');

            // act

            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(0, statistics.Max);
        }
    }
    
}
