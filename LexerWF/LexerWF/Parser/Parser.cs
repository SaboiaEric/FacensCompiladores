using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Compiler.Parser
{
    public class Parser : IParser
    {
  
        private readonly Dictionary<string, IEnumerable<string>> rules;

        private readonly List<string> terminalWords = new List<string>()
        {
            "ASSUMING",
            "OTHERWISE",
            "COMMENCE",
            "CURTAIL",
            "OPERATOR",
            "FLOTIAN",
            "CARDINAL",
            "DECLARATOR",
            "LINEBREAK",
            "WHILST",
            "ACQUIRE",
            "EXHIBIT",
            "SEPARATOR",
        };

        public Parser(string tokens)
        {
                      
        }

        public string GenerateTree()
        {
            string tree = string.Empty;


            return tree;
        }

        /// <summary>
        /// Check if is variable name, number <see cref="int"/> or <see cref="float"/>
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool IsTerminal(string token)
        {
            Regex variableName = new Regex(@"[a-zA-Z_][a-zA-Z0-9]+");
            Regex intNumber = new Regex(@"[-+]?[0-9]*");
            Regex floatNumber = new Regex(@"[-+]?[0-9]*\.?[0-9]+");

            return variableName.Match(token).Success || intNumber.Match(token).Success ||
                floatNumber.Match(token).Success;
        }
        
    }
}
