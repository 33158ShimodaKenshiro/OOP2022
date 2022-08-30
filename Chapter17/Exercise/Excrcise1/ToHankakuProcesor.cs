using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Excrcise1 {
    class ToHankakuProcesor : TextProcessor {
        protected override void Execute(string line) {
            string s = Regex.Replace(line,"[0-9]",p =>((char)(p.Value[0]-'O'+'0')).ToString());
            Console.WriteLine(s);

        }


    }
    }

