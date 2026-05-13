namespace Bibli_Interface
{
    public interface ILacZone
    {
        event EventHandler ZoneInitiation;
        event EventHandler ChangementVueLacZone;
        event EventHandler ClearLacZone;

        public string NomLac { get; }

        public string NomZone { get; }


      
        public void UpdaterVue(string valeurLacZone);

        public void ClearVue();

        public void UpdaterVueZone(string valeurZone);

        public void ClearVueZone();
    }
}
