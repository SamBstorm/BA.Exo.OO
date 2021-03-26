using System;
using System.Collections.Generic;
using System.Text;

namespace BA.Exo.OO._01
{
    public class Banque
    {
        #region Champs
        private Dictionary<string, Courant> _comptes = new Dictionary<string, Courant>();
        #endregion
        #region Props
        public string Nom { get; set; }
        public Courant this[string numero]
        {
            get {
                Courant compte = null;
                if(!_comptes.TryGetValue(numero, out compte)) compte=null; //Gérer message d'erreur
                return compte;
            }

            set {
                if (value.Numero != numero) return; //Gérer message d'erreur
                if (!_comptes.TryGetValue(numero, out _)) return; //Gérer message d'erreur
                _comptes[numero] = value;
            }
        }
        #endregion
        #region Ctor

        #endregion
        #region Methods
        public void Ajouter(Courant compte)
        {
            if (_comptes.TryGetValue(compte.Numero, out _)) return; //Gérer message d'erreur
            _comptes.Add(compte.Numero, compte);
        }

        public void Supprimer(string numero)
        {
            if(!_comptes.Remove(numero)) return; //Gérer message d'erreur 
        }

        public double AvoirDesComptes(Personne titulaire)
        {
            double totalDesAvoirs = 0;
            foreach (KeyValuePair<string,Courant> kvp in _comptes)
            {
                Courant compte = kvp.Value;
                if(compte.Titulaire == titulaire)
                {
                    totalDesAvoirs += compte;
                }
            }
            return totalDesAvoirs;
        }
        #endregion
    }
}
