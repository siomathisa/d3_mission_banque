using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_banque
{
    public class Banque
    {
        private int id;
        private List<Compte> lstComptes;

        public Banque(int id)
        {
            this.id = id;
            this.lstComptes = new List<Compte>();
        }

        public Banque() { }

        public void ajouteCompte(Compte c)
        {
            this.lstComptes.Add(c);
        }

        public void ajouteCompte(int numero, string nom, float solde, float decouvertMax)
        {
            Compte c = new Compte(numero, nom, solde, decouvertMax);
            this.lstComptes.Add(c);
        }
    }
}
