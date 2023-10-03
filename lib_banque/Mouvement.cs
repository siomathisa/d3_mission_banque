using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_banque
{
    public class Mouvement
    {
        private DateTime dateMvt;
        private float montant;

        public DateTime DateMvt
        {
            get { return this.dateMvt; }
            set { this.dateMvt = value; }
        }

        public float Montant
        {
            get { return this.montant; }
            set { this.montant = value; }
        }
        public Mouvement() { }

        public Mouvement(DateTime dateMvt, float montant)
        {
            this.dateMvt = dateMvt;
            this.montant = montant;
        }


    }
}
