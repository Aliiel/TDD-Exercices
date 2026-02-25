namespace Exercice_01.Test;

[TestClass]
public class GetGradeTest
{
    [TestMethod]
    public void WhenGetGrade_95_90_Then_A()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.AttendancePercentage = 95;
        grading.Score = 95;

        // Act 
        var result = grading.GetGrade();

        // Assert 
    }
}
