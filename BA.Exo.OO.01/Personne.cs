using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Personne
    {
        #region Champs
        private string _prenom;
        private DateTime _dateNaiss;
        #endregion
        #region Props
        public string Prenom { 
            get { 
                return _prenom; 
            } 
            set { 
                _prenom = value; 
            } 
        }
        public string Nom { get; set; }
        public DateTime DateNaiss
        {
            get { return _dateNaiss; }
            set { _dateNaiss = value; }
        }
        #endregion
        #region Ctor

        #endregion
        #region Methods
        public override string ToString()
        {
            return $"{Nom} {Prenom} {DateNaiss}";
        }
        #endregion
    }
}
