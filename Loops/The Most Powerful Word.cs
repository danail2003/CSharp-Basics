using System;

namespace The_Most_Powerful_Word
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();   
            
            int allDigit = 0;
            double maxValue = double.MinValue;
            int bonus = 0;           
            string most = "";
            double bonusScore = 0;
            string bonusWord = "";

            while (word != "End of words")
            {
                for (int i = 0; i < word.Length; i++)
                {
                    int digit = word[i];
                    allDigit += digit;
                    
                    if (i == 0)
                    {
                        if (digit == 'a' || digit == 'e' || digit == 'i' || 
                            digit == 'o' || digit == 'u' || digit == 'y' || digit=='A' || digit=='E' 
                            || digit=='I' || digit== 'O' || digit=='U' || digit=='Y')
                        {
                            bonus = word.Length;
                        }                        
                    }
                }

                if (bonus > 0)
                {
                    bonusScore = allDigit * bonus;
                    bonus = 0;
                    bonusWord = word;
                }
                else if (allDigit >= maxValue)
                {
                    maxValue = allDigit;                   
                    most = word;
                }

                allDigit = 0;
                word = Console.ReadLine();
            }

            double total = Math.Floor(maxValue / word.Length);

            if (bonusScore >= total)
            {
                Console.WriteLine($"The most powerful word is {bonusWord} - {bonusScore}");
            }
            else
            {
                Console.WriteLine($"The most powerful word is {most} - {total}");
            }                
        }
    }
}
