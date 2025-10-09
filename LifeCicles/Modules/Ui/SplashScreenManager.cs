using System;
using System.Windows.Forms;
using LifeCicles.Modules.Media;
using LifeCicles.Modules;
using LifeCicles.Modules.UI;


namespace LifeCicles.Modules.UI
{
    internal class SplashScreenManager
    {

        public static SplashVisual AdaptVisual(string mood)
        {

            SplashVisual style;

            switch (mood)
            {
                case "Sereno":
                    style = SplashVisual.DarkAscend;
                    break;
                case "Eufórico":
                    style = SplashVisual.SurrealPulse;
                    break;
                case "Melancólico":
                    style = SplashVisual.MinimalFade;
                    break;
                case "Ritualístico":
                    style = SplashVisual.LightDescend;
                    break;
                default:
                    style = SplashVisual.MinimalFade;
                    break;
            }

            return style;

        }


        public void ShowEntrySplash()
        {

            // Primeiro, obtém o estado emocional
            string mood = HydraMediaLexicon.GetCurrentMood();

            // Depois, invoca os elementos cerimoniais
            string message = HydraMediaLexicon.GetSplashMessage(mood);
            string music = HydraMediaLexicon.GetSuggestedTrack(mood);
            SplashVisual style = SplashScreenManager.AdaptVisual(mood);

            // Finalmente, constrói e mostra o splash
            var splash = new SplashForm
            {
                Message = message,
                MusicPath = music,
                VisualStyle = style
            };

            splash.Show();





        }


        public void ShowExitSplash()
        {
            var splash = new SplashForm
            {
                Message = "🌌 Encerramento cerimonial\nA Hydra repousa, mas a memória permanece.",
                MusicPath = "Assets/Sounds/wagner_outro.mp3",
                VisualStyle = SplashVisual.LightDescend
            };
            splash.Show();
        }
    }

    internal enum SplashVisual
    {
        DarkAscend,
        LightDescend,
        SurrealPulse,
        MinimalFade
    }

    internal class SplashForm : Form
    {
        public string Message { get; set; }
        public string MusicPath { get; set; }
        public SplashVisual VisualStyle { get; set; }

    }
}

