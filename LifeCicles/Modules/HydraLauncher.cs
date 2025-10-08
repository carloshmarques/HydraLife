using LifeCicles.Modules.Media;
using LifeCicles.Modules.UI;
using System;

namespace LifeCicles.Modules
{
    internal class HydraLauncher
    {
        public static void Launch()
        {
            Console.WriteLine("🚪 Iniciando ritual de entrada da Hydra...");

            string mood = HydraMediaLexicon.GetCurrentMood();
            string message = HydraMediaLexicon.GetSplashMessage(mood);
            string music = HydraMediaLexicon.GetSuggestedTrack(mood);
            SplashVisual style = SplashScreenManager.AdaptVisual(mood);


            var splash = new SplashForm
            {
                Message = message,
                MusicPath = music,
                VisualStyle = style
            };

            splash.Show();

            Console.WriteLine("🌀 Ritual iniciado. A Hydra está desperta.");
        }
    }
}
