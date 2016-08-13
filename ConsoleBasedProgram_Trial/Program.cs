using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBasedProgram_Trial
{
    class Program
    {

        StreamReader r;
        Table table;



        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.readingFile();



            Console.Read();
        }



        void readingFile()
        {
            table = new Table();
            table.InitializingDictionarys();


            using (r = new StreamReader("C:/Users/Able/Desktop/3rdAssignment/CNet-Repo/File_Compression_Application/ConsoleBasedProgram_Trial/IronHeel.txt"))
            {

                char[] buffer = new char[1024];
                int read;

                while ((read = r.ReadBlock(buffer, 0, buffer.Length)) > 0)
                {

                    for (int i = 0; i < read; i++)
                    {
                        //  Console.WriteLine(buffer[i]);

                        if (table.occurance.ContainsKey(buffer[i].ToString()))
                        {
                            table.occurance[buffer[i].ToString()] += 1;
                        }
                        else if(buffer[i].ToString() == " " || buffer[i].ToString() == "," || buffer[i].ToString() ==":" || buffer[i].ToString()  ==";"){
                            
                            table.occurance[buffer[i].ToString()] += 1;
                        }

                    }//1st for loop to loop though all the characters in the file

                }//While

            }//using

            //Call to the print method
            DictionaryPrintMethod();

        }//Method





        void DictionaryPrintMethod()
        {
            Console.WriteLine("\n\n\n\n");

            foreach (KeyValuePair<string, int> kvp in table.occurance)
            {
               
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

        }




    }
}
