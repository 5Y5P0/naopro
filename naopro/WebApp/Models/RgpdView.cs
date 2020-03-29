using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RgpdView
    {    
        /// <summary>
        /// Durée de conservation en mois
        /// </summary>
        public ItemRgpd Cookie { get; set; }
        public ItemRgpd General { get; set; }

        //TODO creer une adresse mail rgpd dédié : https://www.cnil.fr/sites/default/files/atoms/files/bpi-cnil-rgpd_fiche-1_que-faire-quand-votre-entreprise-communique-vend-en-ligne.pdf
        public string Mail { get; set; }
    }

    public class ItemRgpd
    {
        public int TimeLife { get; set; }
    }
}
