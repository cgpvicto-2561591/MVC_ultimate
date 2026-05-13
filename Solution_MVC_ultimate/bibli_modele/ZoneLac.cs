namespace Bibli_Modele
{
    public class ZoneLac
    {
        private string _nom;

        /// <summary>
        /// constructeur de Zone
        /// </summary>
        /// <param name="nom">string represantant le nom de la zone</param>
        public ZoneLac(string nom)
        {
            Nom = nom;
        }

        /// <summary>
        /// constructeur vide
        /// </summary>
        public ZoneLac()
        {
        }

        /// <summary>
        /// genere un string nome Zone + un numero en string 
        /// </summary>
        /// <param name="numero">int numero</param>
        /// <returns>string "Zone" + numero.ToString();</returns>
        public string ZoneGenerer(int numero)
        {
           string temp = "Zone" + numero.ToString();
            return temp;
        }

        public string Nom { get => _nom;private set => _nom = value; }
    }
}
