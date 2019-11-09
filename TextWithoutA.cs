//Francisco Jiménez Velasco
using System;
class TextWithOutA
{
    static void Main()
    {
        string word;
        bool askedLetter = true;
        
        do 
        {
            Console.Write("Type a text: ");
            word = Console.ReadLine();
           
            askedLetter = true;
            
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
                if((letter == 'a')||(letter == 'A'))
                    askedLetter = false;
            }
        }
        while (!askedLetter);
    }
}
