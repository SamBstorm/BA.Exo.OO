using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Courant : Compte
    {
        #region Champs
        private double _ligneDeCredit;
        #endregion
        #region Props
        //public double Solde { get; private set; }

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
        
        public override void Retrait(double montant)
        {
            base.Retrait(montant, LigneDeCredit);
        }

        public static double operator +(Courant left, Courant right)
        {
            double solde_left = 0, solde_right = 0;
            if (left.Solde > 0) solde_left = left.Solde;
            if (right.Solde > 0) solde_right = right.Solde;
            return solde_left + solde_right;

            //return ((left.Solde > 0) ? left.Solde : 0) + ((right.Solde > 0) ? right.Solde : 0); //en une ligne
        }
        public static double operator +(double left, Courant right)
        {
            double solde_right = 0;
            if (right.Solde > 0) solde_right = right.Solde;
            return left + solde_right;

            //return left + ((right.Solde > 0) ? right.Solde : 0); //en une ligne
        }
        #endregion


    }
}
