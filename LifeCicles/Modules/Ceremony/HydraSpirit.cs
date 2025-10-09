using System;

namespace LifeCicles.Modules.Ceremony
{
    public static class HydraSpirit
    {
        private static string[] moods = { "Sereno", "Eufórico", "Melancólico", "Ritualístico" };

        public static string GetCurrentMood()
        {
            // Por agora, devolve um mood aleatório
            Random rng = new Random();
            int index = rng.Next(moods.Length);
            return moods[index];
        }
    }
}
