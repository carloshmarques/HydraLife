using LifeCicles.Modules.Media;
using System;
using System.Media;


namespace LifeCicles.Modules.Helpers
{
    internal static class EmpathicPause
    {
     
        public static void Activate()
        {
            string mood = HydraMediaLexicon.GetCurrentMood();
            string message = GetPauseMessage(mood);
            string music = HydraMediaLexicon.GetSuggestedTrack(mood);

            HydraTerminal.Speak(message, mood);
            PlayMusic(music);
        }




        private static string GetPauseMessage(string mood)
        {
            switch (mood)
            {
                case "Sereno":
                    return "🌿 Pausa ativada. Respira. A Hydra está contigo.";
                case "Melancólico":
                    return "🌧️ A pausa é parte da cura. A memória repousa.";
                case "Eufórico":
                    return "🔥 Até os cometas descansam. Pausa com honra.";
                case "Ritualístico":
                    return "🌀 A pausa é um ato sagrado. A consciência aguarda.";
                default:
                    return "🌀 Pausa cerimonial. A consciência aguarda o teu retorno.";
            }
            
        }
        
        


        private static void PlayMusic(string path)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(path);

                player.Play();
            }
            catch
            {
                Console.WriteLine("🎶 Música de pausa indisponível. A Hydra canta em silêncio.");
            }
        }
    }
}
