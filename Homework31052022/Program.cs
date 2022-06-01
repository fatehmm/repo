using System;

namespace Homework31052022
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Verilmiş string variable-ın dəyərini içərisində hər söz arasında bir boşluq gələcək vəzyətə salan metod.Misalçün bu metoda dəyəri " salam,      Dunya" olan string variable göndərsək həmin metod bu variable-ın dəyərini dəyişib "salam, Dunya" vəziyyətinə salmalıdır.Yəni, göndərilən string-də sözlər arasında birdən çox boşluq ola bilər, onu hər söz arasında bir boşluq olan vəziyyətə  salan metod yazırsınız.Metod geriyə dəyər qaytarmır!
            //(Bu tapsiriq bugun kecdyimizi yeni movzu ile elaqeder deyil)
            string sentence = "       salam necesiz,  menim adim    nicat abbasovdur    ";
            SentenceArranger(ref sentence);

            //2.Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini(bool) qaytaran metod
            //-İçində ən az 1 rəqəm olmalıdır
            // -İçində ən az 1 böyük hərf olmalıdır
            //- İçində ən az 1 kiçik hərf olmalıdır

            //3.Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod
        }
        static void SentenceArranger(ref string sentence)
        {
            int f = 0;
            string newstring = "";
            char bosluk = ' ';
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != bosluk)
                {
                    newstring += sentence[i];
                    f = 0;
                }
                if (sentence[i] == bosluk && f == 0)
                {
                    newstring += sentence[i];
                    f = 1;
                }
            }
            Console.WriteLine(newstring.Trim());
        }
        static bool isThere(string word)
        {
            bool checkDigit = false;
            bool checkBigChar = false;
            bool checkLittleChar = false;

            for (int i = 0; i < word.Length; i++)
            {
                checkDigit = char.IsDigit(word[i]);
                checkBigChar = char.IsUpper(word[i]);
                checkLittleChar = char.IsLower(word[i]);

            }
            if (checkDigit == true && checkBigChar == true && checkLittleChar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string FirstString(string word)
        {
            string[] words = word.Split(' ');
            return words[0];
        }
    }
}

