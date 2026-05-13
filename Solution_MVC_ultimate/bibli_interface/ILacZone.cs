namespace Bibli_Interface
{
    public interface ILacZone
    {
        event EventHandler ZoneInitiation;
        event EventHandler ChangementVueLacZone;
        event EventHandler ClearLacZone;
        event EventHandler NumValueChanged;
        public string NomLac { get; }

        public string NomZone { get; }

        public decimal NumZone { get; }
      
        public void UpdaterVue(string valeurLacZone);

        public void ClearVue();

        public void UpdaterVueZone(string valeurZone);

        public void ClearVueZone();

        public void NumUpdate(string numValeur);
        
    }
}
