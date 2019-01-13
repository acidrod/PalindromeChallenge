using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Helper
{
    public static class Palindrome
    {
        /// <summary>
        /// Analiza si una frase, palabra o numero son palíndromos.
        /// </summary>
        /// <param name="word">Un string para ser analizado</param>
        /// <returns>Boolean</returns>
        /// <example>
        /// //Example 1
        /// string myPhrase = "Maps, DNA, and spam";
        /// bool palCheck = myPhrase.IsPalindrome();
        /// 
        /// //Example 2
        /// if("Maps, DNA, and spam".IsPalindrome() == true){
        ///     Console.WriteLine("You had found a palindrome!, congratulations!")
        /// }
        /// else
        /// {
        ///     Console.WriteLine("Nope!, try a new phrase...");
        /// }
        /// </example>

        // Extention Method for strings
        public static bool IsPalindrome(this string word)
        {
            //Normaliza la frase para analizar
            word = FixWord(word);

            //Valida que word tenga al menos 3 caracteres de largo para analizar
            if (!(word.Length >= 3))
            {
                return false;
            }

            int posIzq = 0;
            int posDer = word.Length-1;
            
            //Recorre la variable word desde izquierda a derecha letra por letra
            for (int i = 0; i < word.Length-1; i++)
            {
                if (word[posIzq] == word[posDer])
                {
                    posIzq++;
                    posDer--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        // Extention Method for integers
        public static bool IsPalindrome(this int number)
        {
            return IsPalindrome(number.ToString());
        }

        // Extention Method for doubles
        public static bool IsPalindrome(this double number)
        {
            return IsPalindrome(number.ToString());
        }

        private static string FixWord(string word)
        {
            //Initial normalization (Trim, LowerCase, Replace (blanks, colons and periods)
            word = word.Trim().ToLower().Replace(" ", "").Replace(".", "").Replace(",", "");

            //Remove Specials Pass 1
            Regex pattern = new Regex("[:!¡“”@#$%^&*()}{|\":¿?><\\[\\]\\;'/.,~]");
            word = pattern.Replace(word,"");

            //Remove Specials Pass 2 (Language special characters)
            string normalized = word.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            foreach (var c in normalized)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(c);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
