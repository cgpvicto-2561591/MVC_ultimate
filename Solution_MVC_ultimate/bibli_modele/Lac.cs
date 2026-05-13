using System;
using System.Collections.Generic;
using System.Text;

namespace Bibli_Modele
{
    public class Lac
    {
        private string _nom;
        /// <summary>
        /// constructeur de Lac
        /// </summary>
        /// <param name="nom">string represantant le nom</param>
        public Lac(string nom)
        {
            Nom = nom;
        }
        /// <summary>
        /// get set de _nom
        /// </summary>
        public string Nom { get => _nom;private set => _nom = value; }
    }
}
