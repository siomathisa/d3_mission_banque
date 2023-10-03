using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_banque
{
    public class Banque
    {
        private List<Compte> lstComptes;
        private List<Type> mesTypes;

        public Banque()
        {
            this.lstComptes = new List<Compte>();
            this.mesTypes = new List<Type>();
        }

        public void ajouteCompte(Compte c)
        {
            this.lstComptes.Add(c);
        }

        public void ajouteCompte(int numero, string nom, float solde, float decouvertMax)
        {
            Compte c = new Compte(numero, nom, solde, decouvertMax);
            this.lstComptes.Add(c);
        }

        public void AjouterType(string code, string libelle, char sens)
        {
            this.mesTypes.Add(new Type(code, libelle, sens));
        }
        public void AjouterType(Type unType)
        {
            this.mesTypes.Add(unType);
        }
        public Type GetType(string code)
        {
            Type type = null;
            foreach (Type t in this.mesTypes)
            {
                if(code == t.Getcode)
                {
                    type = t;
                }
            }
            return type;
        }
    }
}
