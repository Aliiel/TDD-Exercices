using Exercices.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices
{
    public class RechercheVille
    {
        private List<String> _villes;

        public RechercheVille(List<string> villes)
        {
            _villes = villes;
        }

        public List<String> Rechercher(String mot)
        {
            if (mot.Equals("*")) return _villes;

            if (mot.Length < 2) throw new NotFoundException("Votre recherche doit contenir plus de 2 caractères");

            return _villes.Where(ville => ville.ToLower().Contains(mot.ToLower())).ToList();
        }
    }
}
