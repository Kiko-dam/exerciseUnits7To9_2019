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
            word = Console.ReadLine().ToUpper();
           
            askedLetter = true;
            
            foreach (char letter in word)
            {
                
                if(letter == 'A')
                    askedLetter = false;
            }
        }
        while (!askedLetter);
    }
}
