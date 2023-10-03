using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_banque
{
    public class Type
    {
        private string code;
        private string libelle;
        private char sens;

        public string Getcode
        {
            get { return this.code; }
            set { this.code = value; }
        }

        public string Getlibelle
        {
            get { return this.libelle; }
            set { this.libelle = value; }
        }

        public char Getsens
        {
            get { return this.sens; }
            set { this.sens = value; }
        }

        public Type() { }

        public Type(string code, string libelle, char sens)
        {
            this.code = code;
            this.libelle = libelle;
            this.sens = sens;
        }

        public override string ToString()
        {
            return $"code : {this.code} libelle : {this.libelle} sens : {this.sens}";
        }
    }
}
