using Bibli_Interface;
using Bibli_Modele;
namespace Bibli_Controleur
{
    public class ControleurGeneral
    {
        private readonly CombineLacZone _modeleLacZone;
        private readonly ZoneLac _modeleZone;
        private readonly ILacZone _vueLacZone;

        public ControleurGeneral(CombineLacZone modeleLacZone, ZoneLac modeleZone, ILacZone vueLacZone)
        {
            _modeleLacZone = modeleLacZone;
            _modeleZone = modeleZone;
            _vueLacZone = vueLacZone;

            _vueLacZone.ChangementVueLacZone += UpdaterModele;
            _modeleLacZone.ChangementModeleList += UpdaterVue;
            _vueLacZone.ZoneInitiation += InitierZone;
            _vueLacZone.ClearLacZone += ClearList;
            // il faut simplement utiliser la function
            // _vueLacZone.ZoneInitiation?.Invoke(this, EventArgs.Empty);

            InitierZone(this, EventArgs.Empty);
        }
        /// <summary>
        /// CLear la listbox avec CLearVue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearList(object sender, EventArgs e)
        {
            _modeleLacZone.CLearInfo();
            _vueLacZone.ClearVue();
        }

        /// <summary>
        /// update la list du modele 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdaterModele(object sender, EventArgs e)
        {
            string valeurLac = _vueLacZone.NomLac;
            string valeurZone = _vueLacZone.NomZone;
            _modeleLacZone.ajouterInfo(valeurLac, valeurZone);
        }

        /// <summary>
        /// update la listbox de la vue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdaterVue(object sender, EventArgs e)
        {
            _vueLacZone.ClearVue();
            for (int i = 0; i < _modeleLacZone.ListCombine.Count; i++)
            {
                _vueLacZone.UpdaterVue(_modeleLacZone.ListCombine[i]);
            }
            
       
        }
        /// <summary>
        /// initie les 28 zone dans combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitierZone(object sender, EventArgs e)
        {
            for (int i = 1; i < 29; i++)
            {
                _vueLacZone.UpdaterVueZone(_modeleZone.ZoneGenerer(i));
            }
           
        }
    }
}
