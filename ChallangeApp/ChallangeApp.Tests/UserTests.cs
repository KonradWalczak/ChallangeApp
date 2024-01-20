namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectsTwoPoints_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Janek","Piotrzkowski",66);
            employee.AddPoints(30);
            employee.AddPoints(20);
            employee.RemovePoints(50);
            //act
            var result = employee.Points;

            //assert

            Assert.AreEqual(0, result);
        }
    }
}