using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_banque
{
    public class Compte
    {
        private int numero;
        private string nom;
        private float solde;
        private float decouvertMax;

        public int GetNumero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string GetNom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public float GetSolde
        {
            get { return this.solde; }
            set { this.solde = value; }
        }

        public float GetDecouvertMax
        {
            get { return this.decouvertMax; }
            set { this.decouvertMax = value; }
        }

        public Compte() { }
        public Compte(int numero, string nom, float solde, float decouvertMax)
        {
            this.numero = numero;
            this.nom = nom;
            this.solde = solde;
            this.decouvertMax = decouvertMax;
        }

        public bool Debiter(float montant)
        {

            this.solde -= montant;
            if (this.solde >= this.decouvertMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Crediter(float montant)
        {
            this.solde += montant;
        }
        public bool Transferer(float montant, Compte c)
        {
            this.solde -= montant;
            c.GetSolde += montant;

            if (this.solde >= this.decouvertMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Superieur(Compte c)
        {
            if (this.solde < c.GetSolde)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"numero : {this.numero} nom : {this.nom} solde : {this.solde} découvert autorisé : {this.decouvertMax}";
        }


    }
}
