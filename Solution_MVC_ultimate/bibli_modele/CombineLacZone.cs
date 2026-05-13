using System;
using System.Collections.Generic;
using System.Text;

namespace Bibli_Modele
{
    public class CombineLacZone
    {
        private List<string> _listCombine = new List<string>();
        public event EventHandler ChangementModeleList;

        /// <summary>
        /// constructeur de CombineLacZone
        /// </summary>
        /// <param name="listCombine">list represantant un lac et une zone</param>
        public CombineLacZone(List<string> listCombine)
        {
            ListCombine = listCombine;
        }

        /// <summary>
        /// constructeur vide
        /// </summary>
        public CombineLacZone()
        {
        }

        /// <summary>
        /// method me permettant d'ajouter un string lac et un string zone en 1 seul string dans ma list
        /// </summary>
        /// <param name="lac">string represantant le nom du lac</param>
        /// <param name="zone">String represantant le nom de la zone</param>
        public void ajouterInfo(string lac,string zone)
        {
            
            ListCombine.Add(lac + ", " + zone);
            ChangementModeleList?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// clear la listCombine
        /// </summary>
        public void CLearInfo()
        {
            ListCombine.Clear();
        }
        /// <summary>
        /// get set _listCombine
        /// </summary>
        public List<string> ListCombine 
        {
            get => _listCombine;
            private set 
            {
                _listCombine = value;
            }
        }
    }
}
