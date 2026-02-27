using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercices.Core.Exercice_04.Models
{
    public class Frame
    {
        private int score;
        private bool _lastFrame;
        private IGenerateur _generateur;
        private List<Roll> rolls;

        public Frame(IGenerateur generateur, bool lastFrame)
        {
            _lastFrame = lastFrame;
            _generateur = generateur;
            rolls = new List<Roll>();
        }

        public int GetScore()
        {
            return score;
        }

        public bool IsLastFrame()
        {
            return _lastFrame;
        }

        public bool MakeRoll()
        {
            throw new NotImplementedException();
        }
    }
}
