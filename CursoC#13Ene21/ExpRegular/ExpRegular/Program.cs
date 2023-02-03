using System;
using System.Text.RegularExpressions;

namespace ExpRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expresiones Regulares. Video 70");
            string frase = "Mi nombre es GECS y mi número telefono (+57)123-444-334";
            string pather = "[G]";
            Regex objReg = new Regex(pather);
            MatchCollection objMatch = objReg.Matches(frase);
            if (objMatch.Count > 0) Console.WriteLine("SI se encontro G ");
            else Console.WriteLine("NO hay G ");
            ////////////////////////////////////////////////
            /// Usar expresiones regulares en busqueda::   " .* "
            /// \d señala valores numéricos 
            /// salto línea, tabulacion::::::::::::::::@@@@  para: +  \  son caracteres escape.
            /// /// salto línea, tabulacion:::::::::::::\\\\  para: +  \  son caracteres escape.
            string pather1 = @"\d";
            Regex objReg1 = new Regex(pather1);
            MatchCollection objMatch1 = objReg1.Matches(frase);
            if (objMatch1.Count > 0) Console.WriteLine("SI se encontro Números ");
            else Console.WriteLine("NO hay Números");
            /// bloques de tres números
            /// Usar expresiones regulares en busqueda::   " .* "
            /// en Busqueda con \d\d\d señala valores numéricos y número valor númerico
            /// \d\d\d === \d{3}-   tre numero y guión.
            /// 
            string pather2 = @"\d{3}-";
            Regex objReg2 = new Regex(pather2);
            MatchCollection objMatch2 = objReg2.Matches(frase);
            if (objMatch2.Count > 0) Console.WriteLine("SI se encontro Números Teléfono {0} ", pather2);
            else Console.WriteLine("NO hay Números Teléfono ", pather2 );
            // \d{3}-\d{3}-\d{3}
            string pather3 = @"\d{3}-\d{3}-\d{3}";
            Regex objReg3 = new Regex(pather3);
            MatchCollection objMatch3 = objReg3.Matches(frase);
            if (objMatch3.Count > 0) Console.WriteLine("SI se encontro Números Teléfono {0} ", pather3);
            else Console.WriteLine("NO hay Números Teléfono ", pather3);
            // \+57 de Colombia  44 reino unido
            string pather4 = @"\+57";
            Regex objReg4 = new Regex(pather4);
            MatchCollection objMatch4 = objReg4.Matches(frase);
            if (objMatch4.Count > 0) Console.WriteLine("SI se encontro Números Teléfono Colombia {0} ", pather4);
            else Console.WriteLine("NO hay Números Teléfono ", pather4);
            //////////////////////////////////////////////////////////////////
            ///  Alt 124  "|"  Alt 92   "\"
            string frase1 = "Mi nombre es GECS y varios número telefono (+57)123-444-334, (+44)234-56";
            // \+57|+45
            string pather5 = @"\+58|\+44";
            Regex objReg5 = new Regex(pather5);
            MatchCollection objMatch5 = objReg5.Matches(frase1);
            if (objMatch5.Count > 0) Console.WriteLine("SI se encontro Números Teléfono {0} ", pather5);
            else Console.WriteLine("NO hay Números Teléfono ", pather5);
            //////////////////////////////////////////////////////////////////
            ///  Alt 124  "|"  Alt 92   "\"   ???????????????
            string frase2 = "Mi WEB es http://www.pildorasinformaticas.es";
            // \+57|+45
            string pather6 = "https?://(www.)?pildorasinformaticas.es";
            Regex objReg6 = new Regex(pather6);
            MatchCollection objMatch6 = objReg6.Matches(frase2);
            if (objMatch6.Count > 0) Console.WriteLine("SI se encontro WEB {0} con o sin s, con o sin (www.) ", pather6);
            else Console.WriteLine("NO hay WEB {0} ", pather6);
            ////////////////////////////////////////////////////////
            string txt0 = "42 43";
            string re10 = ".*?"; // Non-greedy match on filler
            string re20 = "\\d+";    // Uninteresting: int
            string re30 = ".*?"; // Non-greedy match on filler
            string re40 = "(\\d+)";  // Integer Number 1
            Regex r0 = new Regex(re10 + re20 + re30 + re40, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m0 = r0.Match(txt0);
            if (m0.Success)
            {
                String int1 = m0.Groups[1].ToString();
                Console.Write("(" + int1.ToString() + ")" + "\n");
                Console.WriteLine("SI correcto formato nn nn ");
            }
            /////////////////////////////////////////////////////
            ///
            string txt = "curso1@todos.es";
            string re1 = ".*?"; // Non-greedy match on filler
            string re2 = "(@)";    // Any Single Character 1
            string re3 = ".*?"; // Non-greedy match on filler
            string re4 = "(\\.)";  // Integer Number 1
            Regex r = new Regex(re1 + re2 + re3 + re4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match m = r.Match(txt);
            if (m.Success)
            {
                String int1 = m.Groups[1].ToString();
                Console.Write("(" + int1.ToString() + ")" + "\n");
                Console.WriteLine("SI correcto email {0}", txt) ;
            }
            else Console.WriteLine("NO correcto email ");
        }
    }
}
//////////////////////////////////////////////////////////////////////////
/// Exprersión Regular
/// secuencias caracteres funcionan como patrón de Validación, Busqueda.
/// Clases: Regex
///         Match
///         MatchCollection
///         GroupCollection
/// Métodos: Matches
/// Propiedad: Groups
/// Alt 92   "\"
/// Alt 124  "|"
/// \d{3}   Evalua Patrón SI Hay tres números seguidos
/// 152-33-
/// 
/// https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
/// /////////////////////////////////
///  Barra vertical  
/// ////////////////////////////// 
/// ///  Cuantificadores
///  ?  Coincide cero o una vez
///  +  Coincide una o más veces.
///  *  Coincide cero o más veces
///  regex c# generator online
///  http://www.txt2re.com/index3_s_42_43_2.html
///  https://www.i-programmer.info/news/90-tools/3398-online-regular-expression-generator.html
///  https://regex101.com/
