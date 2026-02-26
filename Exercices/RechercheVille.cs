using Exercices.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices
{
    public class RechercheVille
    {
        private List<String> _villes = new List<string> { "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul" };

        public List<String> Rechercher(String mot)
        {
            if (mot.Length <= 2) throw new NotFoundException("Votre recherche doit contenir plus de 2 caractères");

            return _villes;
        }
    }
}
