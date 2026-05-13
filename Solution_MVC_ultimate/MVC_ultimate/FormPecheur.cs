using Bibli_Interface;

namespace MVC_ultimate
{
    public partial class FormPecheur : Form, ILacZone
    {
        public string NomLac => textBoxNomLac.Text;

        public string NomZone => comboBoxZone.SelectedItem.ToString();

        public FormPecheur()
        {
            InitializeComponent();

        }

        public event EventHandler ChangementVueLacZone;
        public event EventHandler ZoneInitiation;
        public event EventHandler ClearLacZone;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNomLac_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Lorsque le buttonAjouter recoit un click il envoie un evenement au controleurGeneral
        /// </summary>
        /// <param name="sender">objet qu'il recoit</param>
        /// <param name="e">event qu'il recoit</param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            ChangementVueLacZone?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxLacZone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// updater la listbox
        /// </summary>
        /// <param name="valeurLac">string qui represente le nom du lac</param>
        /// <param name="valeurZone">string qui represente le nom de la Zone</param>
        /// <exception cref="NotImplementedException"></exception>
        public void UpdaterVue(string valeurLacZone)
        {
            listBoxLacZone.Items.Add(valeurLacZone);
            textBoxNomLac.Text = "";
        }

        /// <summary>
        /// updater le combobox
        /// </summary>
        /// <param name="valeurZone">string qui represente le nom de la Zone</param>
        public void UpdaterVueZone(string valeurZone)
        {
            comboBoxZone.Items.Add(valeurZone);
        }


        /// <summary>
        /// clearer toute la vue list
        /// </summary>
        public void ClearVue()
        {
            listBoxLacZone.Items.Clear();
        }

        /// <summary>
        /// clearer toute la vue combobox
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void ClearVueZone()
        {
            comboBoxZone.Items.Clear();
        }
        /// <summary>
        /// method quand le buttonCLearList recoit un click
        /// il envoie un l'evenement empty au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearList_Click(object sender, EventArgs e)
        {
            ClearLacZone?.Invoke(this, EventArgs.Empty);
        }
    }
}
