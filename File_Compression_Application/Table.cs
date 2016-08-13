using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace File_Compression_Application
{
    class Table
    {
        private Dictionary<string, int> ascii;
        private Dictionary<string, int> occurance;
        private Dictionary<string, int> frequency;
        private Dictionary<string, int> orderedFrequency;
        private Substitution_Compression_UI FormObj;

      public void InitializingDictionarys()
        {

            ascii = new Dictionary<string, int>();
            ascii.Add("a", 01100001);
            ascii.Add("b", 01100010);
            ascii.Add("c", 01100011);
            ascii.Add("d", 01100100);
            ascii.Add("e", 01100101);
            ascii.Add("f", 01100110);
            ascii.Add("g", 01100111);
            ascii.Add("h", 01101000);
            ascii.Add("i", 01101001);
            ascii.Add("j", 01101010);
            ascii.Add("k", 01101011);
            ascii.Add("l", 01101100);
            ascii.Add("m", 01101101);
            ascii.Add("n", 01101110);
            ascii.Add("o", 01101111);
            ascii.Add("p", 01110000);
            ascii.Add("q", 01110001);
            ascii.Add("r", 01110010);
            ascii.Add("s", 01110011);
            ascii.Add("t", 01110100);
            ascii.Add("u", 01110101);
            ascii.Add("v", 01110110);
            ascii.Add("w", 01110111);
            ascii.Add("x", 01111000);
            ascii.Add("y", 01111001);
            ascii.Add("z", 01111010);
            
            occurance = new Dictionary<string, int>();
            occurance.Add("a", 0);
            occurance.Add("b", 0);
            occurance.Add("c", 0);
            occurance.Add("d", 0);
            occurance.Add("e", 0);
            occurance.Add("f", 0);
            occurance.Add("g", 0);
            occurance.Add("h", 0);
            occurance.Add("i", 0);
            occurance.Add("j", 0);
            occurance.Add("k", 0);
            occurance.Add("l", 0);
            occurance.Add("m", 0);
            occurance.Add("n", 0);
            occurance.Add("o", 0);
            occurance.Add("p", 0);
            occurance.Add("q", 0);
            occurance.Add("r", 0);
            occurance.Add("s", 0);
            occurance.Add("t", 0);
            occurance.Add("u", 0);
            occurance.Add("v", 0);
            occurance.Add("w", 0);
            occurance.Add("x", 0);
            occurance.Add("y", 0);
            occurance.Add("z", 0);
            occurance.Add("space", 0);

            frequency = new Dictionary<string, int>();
            frequency.Add("a", 0);
            frequency.Add("b", 0);
            frequency.Add("c", 0);
            frequency.Add("d", 0);
            frequency.Add("e", 0);
            frequency.Add("f", 0);
            frequency.Add("g", 0);
            frequency.Add("h", 0);
            frequency.Add("i", 0);
            frequency.Add("j", 0);
            frequency.Add("k", 0);
            frequency.Add("l", 0);
            frequency.Add("m", 0);
            frequency.Add("n", 0);
            frequency.Add("o", 0);
            frequency.Add("p", 0);
            frequency.Add("q", 0);
            frequency.Add("r", 0);
            frequency.Add("s", 0);
            frequency.Add("t", 0);
            frequency.Add("u", 0);
            frequency.Add("v", 0);
            frequency.Add("w", 0);
            frequency.Add("x", 0);
            frequency.Add("y", 0);
            frequency.Add("z", 0);
            frequency.Add("space", 0);

            orderedFrequency = new Dictionary<string, int>();
            orderedFrequency.Add("a", 0);
            orderedFrequency.Add("b", 0);
            orderedFrequency.Add("c", 0);
            orderedFrequency.Add("d", 0);
            orderedFrequency.Add("e", 0);
            orderedFrequency.Add("f", 0);
            orderedFrequency.Add("g", 0);
            orderedFrequency.Add("h", 0);
            orderedFrequency.Add("i", 0);
            orderedFrequency.Add("j", 0);
            orderedFrequency.Add("k", 0);
            orderedFrequency.Add("l", 0);
            orderedFrequency.Add("m", 0);
            orderedFrequency.Add("n", 0);
            orderedFrequency.Add("o", 0);
            orderedFrequency.Add("p", 0);
            orderedFrequency.Add("q", 0);
            orderedFrequency.Add("r", 0);
            orderedFrequency.Add("s", 0);
            orderedFrequency.Add("t", 0);
            orderedFrequency.Add("u", 0);
            orderedFrequency.Add("v", 0);
            orderedFrequency.Add("w", 0);
            orderedFrequency.Add("x", 0);
            orderedFrequency.Add("y", 0);
            orderedFrequency.Add("z", 0);
            orderedFrequency.Add("space", 0);

            
        }


        

    }
}
