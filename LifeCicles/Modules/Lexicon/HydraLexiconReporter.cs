using System;
using System.Collections.Generic;

namespace LifeCicles.Modules.Lexicon
{
    internal class HydraLexiconReporter
    {
        public Dictionary<string, LexicalCompartment> Compartments { get; private set; }

        public HydraLexiconReporter()
        {
            Compartments = new Dictionary<string, LexicalCompartment>();
        }

        public void Report(string input)
        {
            string category = LexicalAnalyzer.Categorize(input);
            if (!Compartments.ContainsKey(category))
                Compartments[category] = new LexicalCompartment(category);

            Compartments[category].StoreExpression(input);
            HydraMonitor.ReceiveLexiconReport(category, input);
        }
    }

    internal class LexicalCompartment
    {
        public string Category { get; private set; }
        public List<string> Expressions { get; private set; }

        public LexicalCompartment(string category)
        {
            Category = category;
            Expressions = new List<string>();
        }

        public void StoreExpression(string expression)
        {
            Expressions.Add(expression);
        }
    }

    internal static class LexicalAnalyzer
    {
        public static string Categorize(string input)
        {
            if (input.Contains("catenária")) return "Metáfora Técnica";
            if (input.Contains("melindrosas")) return "Expressão Poética";
            if (input.Contains("dum dum")) return "Gíria Local";
            return "Desvio Linguístico";
        }
    }

    internal static class HydraMonitor
    {
        public static void ReceiveLexiconReport(string category, string expression)
        {
            Console.WriteLine($"🧠 HydraMonitor: '{expression}' categorizado como '{category}'");
        }
    }
}
