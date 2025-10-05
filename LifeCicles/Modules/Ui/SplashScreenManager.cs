using System;
using System.Windows.Forms;

namespace LifeCicles.Modules.Ui
{
    internal class SplashScreenManager
    {
        public void ShowEntrySplash()
        {
            string mood = HydraMediaLexicon.GetCurrentMood();
            string message = HydraMediaLexicon.GetSplashMessage(mood);
            string music = HydraMediaLexicon.GetSuggestedTrack(mood);
            SplashVisual style = HydraThemeManager.AdaptVisual(mood);

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

        public void Show()
        {
            // Aplicar estilo visual
            // Reproduzir música cerimonial
            // Exibir mensagem com animação
            Console.WriteLine($"🎶 Splash: {Message} [{VisualStyle}]");
        }
    }
}

