using Exercices;
using Exercices.Exceptions;

namespace Exercice_03.Test;

[TestClass]
public class RechercheVilleTest
{
    private RechercheVille _rechercheVille = new RechercheVille(new List<string>
    {
        "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
    });

    [TestMethod]
    public void Rechercher_Under_2_Carac_ThenNotFoundException()
    {
        // Assert 
        Assert.ThrowsExactly<NotFoundException>(() => _rechercheVille.Rechercher("l"));
    }


    [TestMethod]
    public void Rechercher_Sup_Or_Egal_2_Carac_ThenResult_Start_With_Carac()
    {
        // Act 
        List<string> result = _rechercheVille.Rechercher("Va");
        List<string> resultExpected = new List<string> { "Valence", "Vancouver" };
        
        // Assert 
        CollectionAssert.AreEqual(resultExpected, result);
    }


    [TestMethod]
    public void RechercherWhen_No_Case_Sensitive()
    {
        // Act 
        List<string> result = _rechercheVille.Rechercher("vA");
        List<string> resultExpected = new List<string> { "Valence", "Vancouver" };

        // Assert 
        CollectionAssert.AreEqual(resultExpected, result);
    }


    [TestMethod]
    public void RechercherWhen_Gt_2_Contains_With_Char()
    {
        // Act 
        List<string> result = _rechercheVille.Rechercher("ape");
        List<string> resultExpected = new List<string> { "Budapest"};

        // Assert 
        CollectionAssert.AreEqual(resultExpected, result);
    }

    [TestMethod]
    public void RechercherWhen_Char_Asterisk_Return_All_Cities()
    {
        // Act 
        List<string> result = _rechercheVille.Rechercher("*");
        List<string> resultExpected = new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" };

        // Assert 
        CollectionAssert.AreEqual(resultExpected, result);
    }
}
