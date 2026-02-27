using Exercices.Core.Exercice_01.Models;

namespace Exercice_01.Test;

[TestClass]
public class GradingCalculatorTest
{
    private GradingCalculator _calculator;

    private void SetUp(int Score, int AttendancePercentage)
    {
        _calculator = new GradingCalculator
        {
            Score = Score,
            AttendancePercentage = AttendancePercentage
        };
    }

    [TestMethod]
    public void WhenGetGrade_95_90_Then_A()
    {
        // Arrange 
        var grading = new GradingCalculator();
        grading.Score = 95;
        grading.AttendancePercentage = 90;

        // Other way : 
        GradingCalculator _grading = new GradingCalculator();
        _grading.Score = 95;
        _grading.AttendancePercentage = 90;

        // An other way 
        GradingCalculator _gradingCalc = new GradingCalculator
        {
            Score = 95,
            AttendancePercentage = 90
        };

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



    // OPTIMISATION | BEST PRACTICE 
    // DataRow = annotation permettant d'injecter des paramètres dans la méthode à test
    [TestMethod]
    [DataRow(95, 90, 'A')]
    [DataRow(85, 90, 'B')]
    [DataRow(65, 90, 'C')]
    [DataRow(95, 65, 'B')]
    [DataRow(95, 55, 'F')]
    [DataRow(65, 55, 'F')]
    [DataRow(50, 90, 'F')]
    public void WhenGetGrade(int Score, int pres, char note)
    {
        SetUp(Score, pres);
        char c = _calculator.GetGrade();
        Assert.AreEqual(note, c);
    }


}
