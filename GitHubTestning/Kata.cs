
namespace GitHubTestning
{
    using System.Text;

    public class Kata
    {
        /*
         *  Complete the method/function so that it converts dash/underscore delimited words into camel casing.
         * The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case,
         * also often referred to as Pascal case).

            Examples
            "the-stealth-warrior" gets converted to "theStealthWarrior"
            "The_Stealth_Warrior" gets converted to "TheStealthWarrior"
         */
        public static string ToCamelCase(string str)
        {

            char[] strChars = str.ToCharArray();
            StringBuilder sbText = new StringBuilder();

            sbText.Append(char.ToUpper(strChars[0]));
            bool check = false;

            for (int i = 1; i < strChars.Length; ++i) //går igenom input str
            {


                char c = strChars[i]; //en char c skapas och tilldelas värdet str[i]

                if (c == '-' || c == '_') //om c är ett - eller _ så:
                {
                    check = true; //ändras check till true. 
                    // lopen avslutas (med andra ord det händer inte så mycket.)
                }
                else if (check) // Men om check är true (dvs var - eller _ i FÖREGÅENDE loop) så:
                {
                    sbText.Append(char.ToUpper(c)); // läggs c till sbText och konverteras till en stor bokstav. 
                    check = false; // check ändras tillbaka false. 
                    //loopen avslutas
                }
                else //för allt annat så: (dvs om c inte är - eller _ och check är false)
                {
                    sbText.Append(char.ToLower(c)); // läggs c till den nya uppbyggda strängen sbText och konverteras till en liten bokstav.
                    //lopen avslutas
                }
            }

            //Detta lägger jag till nu
            int test = 0;

            return sbText.ToString(); //sbText kommer retuneras efter att den konverteras till en sträng. 
        }


    }
}