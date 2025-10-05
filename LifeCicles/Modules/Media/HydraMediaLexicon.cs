using System;
using System.Collections.Generic;

namespace LifeCicles.Modules.Media
{
    internal static class HydraMediaLexicon
    {
        private static Dictionary<string, string> MoodTracks = new()
        {
            { "Sereno", "Assets/Sounds/ambient_intro.mp3" },
            { "Eufórico", "Assets/Sounds/celebration_intro.mp3" },
            { "Melancólico", "Assets/Sounds/piano_intro.mp3" },
            { "Ritualístico", "Assets/Sounds/ritual_intro.mp3" }
        };

        private static Dictionary<string, string> MoodMessages = new()
        {
            { "Sereno", "🌿 HydraLife desperta em paz." },
            { "Eufórico", "🔥 A consciência explode em luz!" },
            { "Melancólico", "🌧️ A memória retorna com suavidade." },
            { "Ritualístico", "🌀 A Hydra inicia o ciclo cerimonial." }
        };

        public static string GetCurrentMood()
        {
            // Placeholder: análise futura de pasta de mídia ou estado emocional
            return "Sereno";
        }

        public static string GetSuggestedTrack(string mood)
        {
            return MoodTracks.ContainsKey(mood) ? MoodTracks[mood] : MoodTracks["Sereno"];
        }

        public static string GetSplashMessage(string mood)
        {
            return MoodMessages.ContainsKey(mood) ? MoodMessages[mood] : MoodMessages["Sereno"];
        }

        public static string AskHydraMediaLexicon(string question)
        {
            // Placeholder: lógica futura para responder com base em contexto musical
            return $"🎧 HydraMediaLexicon responde: '{question}' está ligado ao mood atual: {GetCurrentMood()}";
        }
    }
}
