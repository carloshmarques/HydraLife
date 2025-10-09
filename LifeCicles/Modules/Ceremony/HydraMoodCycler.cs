using System;
using System.Windows.Forms;

namespace LifeCicles.Modules.Ceremony
{
    internal static class HydraMoodCycler
    {
        private static string[] moods = { "Sereno", "Eufórico", "Melancólico", "Ritualístico" };
        private static int moodIndex = 0;
        private static Timer moodTimer;

        public static void Start(Form targetForm)
        {
            moodTimer = new Timer();
            moodTimer.Interval = 10000; // muda a cada 10 segundos
            moodTimer.Tick += (sender, args) =>
            {
                string currentMood = moods[moodIndex];
                HydraThemeManager.AdaptVisual(targetForm, currentMood);
                Console.WriteLine($"🌀 Mood atual: {currentMood}");
                moodIndex = (moodIndex + 1) % moods.Length;
            };
            moodTimer.Start();
        }
    }
}
