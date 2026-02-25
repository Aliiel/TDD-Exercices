using Exercice_01;
using System.Collections;

namespace Exercice_02.Test;

[TestClass]
public class FibTest
{
    private Fib _fib;

    private void Setup(int range)
    {
        _fib = new Fib(range);
    }

    [TestMethod]
    public void GetFibSeries_Range1_ThenResultIsNotEmpty()
    {
        // Arrange 
        Setup(1);

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert 
        Assert.AreNotEqual(0, results.Count());
    }

    [TestMethod]
    public void GetFibSeries_Range1_ThenResultContains0()
    {
        // Arrange 
        Setup(1);
        var expected = new List<int> { 0 };

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert 
        CollectionAssert.AreEquivalent(expected, results);
    }


    [TestMethod]
    public void GetFibSeries_Range6_ThenResultContains3()
    {
        // Arrange 
        Setup(6);

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert 
        Assert.Contains(3, results);
    }

    [TestMethod]
    public void GetFibSeries_Range6_ThenResultContains6Elements()
    {
        // Arrange 
        Setup(6);

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert 
        Assert.HasCount(6, results);
    }

    [TestMethod]
    public void GetFibSeries_Range6_ThenResultNotContains4()
    {
        // Arrange 
        Setup(6);

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert 
        Assert.DoesNotContain(4, results);
    }

    [TestMethod]
    public void GetFibSeries_Range6_ThenResultMatchesToCollection()
    {
        // Arrange 
        Setup(6);
        var collectionToMatch = new List<int> { 0, 1, 1, 2, 3, 5 };

        // Act 
        List<int> results = _fib.GetFibSeries();

        // Assert
        CollectionAssert.AreEqual(collectionToMatch, results);
    }

    [TestMethod]
    public void GetFibSeries_Range6_ThenResultOrderByAsc()
    {
        // Arrange 
        Setup(6);

        // Act 
        List<int> results = _fib.GetFibSeries();
        List<int> resultsSorted = null;

        // Assert 
        CollectionAssert.AreEquivalent(resultsSorted, results);
    }
}
