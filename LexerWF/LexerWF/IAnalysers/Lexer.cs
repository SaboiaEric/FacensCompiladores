using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compiler.Analysers
{
    public class Lexer : IAnalyser
    {
        public Dictionary<string, Regex> regexes { get; set; }

        public Lexer()
        {
            this.regexes = new Dictionary<string, Regex>()
            {
                { "ASSUMING", new Regex(@"assuming", RegexOptions.None) },
                { "OTHERWISE", new Regex(@"otherwise", RegexOptions.None) },
                { "COMMENCE", new Regex(@"commence", RegexOptions.None) },
                { "CURTAIL", new Regex(@"curtail", RegexOptions.None) },
                { "OPERATOR", new Regex(@"(\+|\=|\(|\)|\*|\-|\/|>|<|and|or|equal)", RegexOptions.None) },
                { "FLOTIAN", new Regex(@"flotian", RegexOptions.None) },
                { "CARDINAL", new Regex(@"cardinal", RegexOptions.None) },
                { "DECLARATOR", new Regex(@"befall", RegexOptions.None) },
                { "LINEBREAK", new Regex(@"\n", RegexOptions.None) },
                { "WHILST", new Regex(@"whilst", RegexOptions.None) },
                { "ACQUIRE", new Regex(@"acquire", RegexOptions.None) },
                { "EXHIBIT", new Regex(@"exhibit", RegexOptions.None) },
                { "SEPARATOR", new Regex(@",", RegexOptions.None) }
            };
        }

        public List<string> Analyse(string input)
        {
            var current = String.Empty;
            var tokens = new List<string>();
            Match match = null;

            for (int i = 0; i < input.Length; i++)
            {
                current += input[i];

                foreach (var reg in regexes)
                {
                    match = reg.Value.Match(current);
                    if (match.Success)
                    {
                        if (current.Replace(match.Value, String.Empty).Length > 0)
                            tokens.Add(current.Replace(match.Value, String.Empty));
                        tokens.Add(match.Value);
                        current = String.Empty;
                        continue;
                    }
                }
            }

            tokens.Add(current);
            tokens.RemoveAll(x => x.Equals("\n") || x.Equals("\r"));

            return tokens;
        }
    }
}
