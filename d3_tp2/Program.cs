using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib_banque;

    // \*\*\*\*\*\*\*\*\*A àjouter\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\* 
    Banque b = new Banque();
    b.AjouterType("ch", "chèque débité", '-');
    b.AjouterType("pre", "prélèvement", '-');
    b.AjouterType("dab", "retrait en distributeur", '-');
    b.AjouterType("ret", "retrait guichet ", '-');
    b.AjouterType("vir", "virement sur compte", '+');
    b.AjouterType("dch", "chèque déposé", '+');
    b.AjouterType("des", "dépôt d’espèce", '+');
    // \*\*\*\*\*\*\*\*\*\*Fin ajout\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*\*
    Console.WriteLine(b.GetType("ch").ToString());


