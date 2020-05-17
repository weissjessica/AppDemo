using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo_JessicaWeiss
{
    class clsRechnen
    {
        public string rechnen(string op, int v1, int v2 )
        {
            switch (op)
            {
                case "+":
                    return(v1 + v2).ToString();

                case "-":
                    return(v1 - v2).ToString();

                case "x":
                    return(v1 * v2).ToString();

                case ":":
                    return(v1 / v2).ToString();

                
            }
            return "";
        }
    }
}
