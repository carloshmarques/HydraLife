using System;

namespace LifeCicles.Modules.Helpers
{
    internal static class HydraTerminal
    {
        public static void Speak(string message, string mood)
        {
            string prefix;

            switch (mood)
            {
                case "Sereno":
                    prefix = "🌿";
                    break;
                case "Eufórico":
                    prefix = "🔥";
                    break;
                case "Melancólico":
                    prefix = "🌧️";
                    break;
                case "Ritualístico":
                    prefix = "🌀";
                    break;
                default:
                    prefix = "🗣️";
                    break;
            }

            Console.WriteLine($"{prefix} HydraTerminal: {message}");

        }

        public static void SpeakRandom(string mood)
        {
            string[] frases;

            switch (mood)
            {
                case "Empático":
                    frases = new[]
                    {
            "🌿 Respira, Carlos. A pausa é parte do progresso.",
            "🧠 A Hydra está contigo. Até o código precisa de silêncio.",
            "☕ Que tal um café e um momento só teu?"
        };
                    break;
                case "Filosófico":
                    frases = new[]
                    {
            "🌀 Heraclito diria: o bug que corriges hoje é o rio que não voltará a correr igual.",
            "📜 O compilador não erra — ele apenas revela o que ainda não foi entendido.",
            "🔍 A depuração é o espelho da alma do engenheiro."
        };
                    break;
                case "Humorístico":
                    frases = new[]
                    {
            "🔥 A CPU está a suar. Recomendo café, xixi e talvez um exorcismo leve.",
            "🧃 O sistema pediu um sumo de laranja. O terminal está em greve.",
            "💥 Loop infinito detectado. Enviar snacks ou reiniciar a realidade."
        };
                    break;
                case "Surrealista":
                    frases = new[]
                    {
            "☕ O compilador pediu um pastel de nata. O terminal dança com um pato metafísico.",
            "🎩 A Hydra está a conversar com Fernando Pessoa sobre fluxos assíncronos.",
            "🪐 O código entrou em modo galáctico. A lógica está a flutuar em Vila Nova da Cafeteira."
        };
                    break;
                default:
                    frases = new[] { "🗣️ A Hydra fala, mas não sabe o tom. Define o mood, Engenheiro." };
                    break;
            }
            Random rnd = new Random();
            string frase = frases[rnd.Next(frases.Length)];
            Console.WriteLine(frase);



        }
    }
}

