using System;
using System.Collections.Generic;
using System.Text;

namespace Exercices.Core.Exercice_04.Models
{
    public interface IGenerateur
    {
        public int RandomPin(int max);
    }
}
