using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Compte
    {
        #region Champs
        private double _solde;
        #endregion
        #region Props
        public string Numero { get; set; }
        public Personne Titulaire { get; set; }
        public double Solde
        {
            get { return _solde; }
            private set { _solde = value; }
        }
        #endregion
        #region Ctor

        #endregion
        #region Methods
        public void Depot(double montant)
        {
            if (montant <= 0) return; //Gérer message d'erreur
            Solde += montant;
        }

        protected void Retrait(double montant, double limite = 0)
        {
            if (montant <= 0) return;
            if (montant > limite + Solde) return;
            Solde -= montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }
        #endregion
    }
}
