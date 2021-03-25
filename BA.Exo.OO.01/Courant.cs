using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Courant
    {
        #region Champs
        private double _solde;
        private double _ligneDeCredit;
        #endregion
        #region Props
        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        //public double Solde { get; private set; }
        public double Solde
        {
            get { return _solde; }
            private set { _solde = value; }
        }

        public double LigneDeCredit
        {
            get { return _ligneDeCredit; }
            set { 
                if (value >= 0) _ligneDeCredit = value; //Gérer message d'erreur
            }
        }

        #endregion
        #region Ctor

        #endregion
        #region Methods
        public void Depot(double montant)
        {
            if (montant > 0) Solde += montant; //Gérer message d'erreur
        }
        public void Retrait(double montant)
        {
            if (montant > 0) //Gérer message d'erreur
            {
                if (montant <= LigneDeCredit + Solde) Solde -= montant; //Gérer message d'erreur
            }
        }
        #endregion


    }
}
