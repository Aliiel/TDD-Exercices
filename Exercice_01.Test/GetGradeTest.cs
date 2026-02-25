namespace Exercice_01.Test;

[TestClass]
public class GetGradeTest
{
    [TestMethod]
    public void WhenGetGrade_95_90_Then_A()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 95;
        grading.AttendancePercentage = 90;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('A', result);
    }

    [TestMethod]
    public void WhenGetGrade_85_90_Then_B()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 85;
        grading.AttendancePercentage = 90;
       
        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('B', result);
    }

    [TestMethod]
    public void WhenGetGrade_65_90_Then_C()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 65;
        grading.AttendancePercentage = 90;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('C', result);
    }

    [TestMethod]
    public void WhenGetGrade_95_65_Then_B()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 95;
        grading.AttendancePercentage = 65;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('B', result);
    }

    [TestMethod]
    public void WhenGetGrade_95_55_Then_F()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 95;
        grading.AttendancePercentage = 55;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('F', result);
    }

    [TestMethod]
    public void WhenGetGrade_65_55_Then_F()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 65;
        grading.AttendancePercentage = 55;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('F', result);
    }

    [TestMethod]
    public void WhenGetGrade_50_90_Then_F()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 50;
        grading.AttendancePercentage = 90;

        // Act 
        var result = grading.GetGrade();

        // Assert 
        Assert.AreEqual('F', result);
    }
}
