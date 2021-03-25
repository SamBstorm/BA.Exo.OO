using System;

namespace BA.Exo.OO._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Courant courant = new Courant();

            Personne personne = new Personne();

            personne.Nom = "Willis";
            personne.Prenom = "Bruce";
            personne.DateNaiss = new DateTime(1968, 8, 14);

            courant.Numero = "BE557620...";
            courant.Titulaire = personne;
            //courant.Solde = 5000.0; //Impossible : private set ou omission du set
            courant.LigneDeCredit = -200;
            courant.Depot(5000);
            courant.Retrait(200.0);
            courant.Retrait(20000.0);
        }
    }
}
