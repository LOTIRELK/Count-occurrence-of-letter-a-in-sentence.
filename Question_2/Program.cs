using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    //a program that prints the index of each occurrence of the letter 'a' int the string
    //"Happy days are here again"
    class Program
    {
        static void Main(string[] args)
        {
            
            const string happy = "Happy days are here again.";//Instansiate string
            var chars = happy.ToCharArray();//convert string to character array named chars
            for (int i =0; i<chars.Length; i++)//loop to scan through the array
            {
                if(chars[i]=='a')//if the number of the index is eqaul to 'a'
                {
                    Console.WriteLine(i);//output the number of the location in the array
                }
            }
        }
    }
}
