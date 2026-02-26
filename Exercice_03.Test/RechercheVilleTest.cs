using Exercices;
using Exercices.Exceptions;

namespace Exercice_03.Test;

[TestClass]
public class RechercheVilleTest
{
    [TestMethod]
    public void Rechercher_Under_2_Carac_ThenNotFoundException()
    {
        // Arrange 
        var rechercheVille = new RechercheVille();
        string mot = "la";

        // Assert 
        Assert.ThrowsExactly<NotFoundException>(() => rechercheVille.Rechercher(mot));
    }

}
