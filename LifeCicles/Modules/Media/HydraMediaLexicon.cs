using System;
using System.Collections.Generic;
using System.IO.Ports;
using LifeCicles.Modules.Media;


namespace LifeCicles.Modules.Media
{


    internal static class HydraMediaLexicon
    {


        public static void WakeHydra()
        {
            try
            {
                using (SerialPort port = new SerialPort("COM3", 9600))
                {
                    port.Open();
                    port.WriteLine("Hydra, acorda!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Falha ao acordar a Hydra: {ex.Message}");
            }
        }

        private static Dictionary<string, string> MoodTracks = new Dictionary<string, string>()
        {
            { "Sereno", "sereno.mp3" },
            { "Eufórico", "euforico.mp3" },
            { "Melancólico", "melancolico.mp3" },
            { "Ritualístico", "ritual.mp3" }
        };




        public static string GetCurrentMood()
        {
            // Placeholder: análise futura de pasta de mídia ou estado emocional
            return "Sereno";
        }

        public static string GetSuggestedTrack(string mood)
        {
            HydraMediaLexicon.WakeHydra();

            return MoodTracks.ContainsKey(mood) ? MoodTracks[mood] : MoodTracks["Sereno"];
        }
        private static Dictionary<string, string> MoodMessages = new Dictionary<string, string>()
        {
            { "Sereno", "🌿 HydraLife desperta em paz." },
            { "Eufórico", "🔥 A consciência explode em luz!" },
            { "Melancólico", "🌧️ A memória retorna com suavidade." },
            { "Ritualístico", "🌀 A Hydra inicia o ciclo cerimonial." }
        };

        public static string GetSplashMessage(string mood)
        {
            HydraMediaLexicon.WakeHydra();
            
            return MoodMessages.ContainsKey(mood) ? MoodMessages[mood] : MoodMessages["Sereno"];
        }

        public static string AskHydraMediaLexicon(string question)
        {

            HydraMediaLexicon.WakeHydra();
            // Placeholder: lógica futura para responder com base em contexto musical
            return $"🎧 HydraMediaLexicon responde: '{question}' está ligado ao mood atual: {GetCurrentMood()}";
        }
    }
}
