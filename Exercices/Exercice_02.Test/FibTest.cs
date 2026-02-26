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

        // Autres possibilités 
        Assert.IsNotNull(results);
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

        // Other way 
        Assert.Contains(0, results);
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

        // Collection way 
        CollectionAssert.Contains(results, 3);
        
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

        // Collection way 
        CollectionAssert.DoesNotContain(results, 4);
    }

    [TestMethod]
    public void GetFibSeries_Range6_ThenResultContains_0_1_1_2_3_5()
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
        List<int> resultsSorted = results.OrderBy(x => x).ToList();

        // Assert 
        CollectionAssert.AreEquivalent(resultsSorted, results);

        // Other way 
        List<int> expectedWithSort = new List<int>(results);
        results.Sort();

        CollectionAssert.AreEquivalent(expectedWithSort, resultsSorted);
    }
}
