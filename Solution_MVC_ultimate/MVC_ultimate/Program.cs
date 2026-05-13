using System.Security.Policy;
using Bibli_Controleur;
using Bibli_Interface;
using Bibli_Modele;
namespace MVC_ultimate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FormPecheur vue = new FormPecheur();
            ZoneLac modeleZone = new ZoneLac();
            CombineLacZone modeleLacZone = new CombineLacZone();
            ControleurGeneral ctrl = new ControleurGeneral(modeleLacZone, modeleZone, vue);
            Application.Run(vue);
        }
    }
}