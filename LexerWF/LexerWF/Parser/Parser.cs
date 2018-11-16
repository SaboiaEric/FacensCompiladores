using System.Collections.Generic;

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

        
    }
}
