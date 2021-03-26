using System;

namespace BA.Exo.OO._01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exo01
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
            #endregion
            #region Exo02
            Banque banque = new Banque();
            banque.Nom = "MetsTesSousIci";
            banque[courant.Numero] = courant;
            banque.Ajouter(courant);
            banque.Ajouter(courant);
            Console.WriteLine(banque["BE557620..."]?.Titulaire?.Nom);
            banque["BE557620..."].Depot(5000);
            banque.Supprimer("BE557620...");
            banque.Supprimer("BE557620...");
            Console.WriteLine(banque["BE557620..."]?.Titulaire?.Nom);
            #endregion
            #region Exo03
            banque.Ajouter(courant);
            Courant c1 = new Courant();
            c1.Numero = "BE364512...";
            c1.Titulaire = personne;
            c1.LigneDeCredit = 200;
            c1.Retrait(150);
            banque.Ajouter(c1);
            Personne p1 = new Personne();
            p1.Nom = "Stalone";
            p1.Prenom = "Sylverster";
            p1.DateNaiss = new DateTime(1972, 5, 1);
            Courant c2 = new Courant();
            c2.Numero = "BE999999...";
            c2.Titulaire = p1;
            c2.LigneDeCredit = 200;
            c2.Depot(6000);
            c2.Retrait(150);
            banque.Ajouter(c2);

            banque.AvoirDesComptes(personne);
            banque.AvoirDesComptes(p1);
            banque.AvoirDesComptes(new Personne() { Nom = "Stalone", Prenom = "Sylverster", DateNaiss = new DateTime(1972, 5, 1) });
            #endregion
        }
    }
}
