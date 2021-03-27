using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Epargne : Compte
    {
        #region Champs

        #endregion
        #region Props
        public DateTime DateDernierRetrait { get; set; }
        #endregion
        #region Ctor

        #endregion
        #region Methods
        public override void Retrait(double montant)
        {
            base.Retrait(montant);
            DateDernierRetrait = DateTime.Now;
        }
        #endregion
    }
}
