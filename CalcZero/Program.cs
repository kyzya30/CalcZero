using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalcZero
{
    class Program
    {
        static int maxZero = 0;

        static void Main(string[] args)
        {
           // CreateInputTXT();
            FindZeros();
            WriteZeroToTXT();
            //Console.WriteLine(maxZero);
        }
        static void WriteZeroToTXT()
        {
            StreamWriter txtFile = new StreamWriter("OUTPUT.TXT");
            for (int i = 0; i < maxZero; i++)
            {
                txtFile.Write(0);
            }
            txtFile.Close();
        }
        static void FindZeros()
        {
            string[] readTxt = File.ReadAllLines("INPUT.TXT");
            int tmpMaxCountZero = 0;
            foreach (string str in readTxt)//Read all lines
            {
                for (int i = 0; i < str.Length; i++)//Read digit in line
                {
                    // Console.Write(str[i]);
                    if (str[i] == '0')
                    {
                        tmpMaxCountZero++;
                    }
                    if (str[i] == '1')
                    {
                        if (tmpMaxCountZero > maxZero)
                        {
                            maxZero = tmpMaxCountZero;
                            tmpMaxCountZero = 0;
                        }
                        else
                        {
                            tmpMaxCountZero = 0;
                        }
                    }
                }
            }
        }
        static void CreateInputTXT()
        {
            Random r = new Random();
            StreamWriter txtFile = new StreamWriter("INPUT.TXT");
            for (int i = 0; i < 100; i++)
            {
                txtFile.Write(r.Next(0, 2));
            }
            txtFile.Close();
            StreamReader rTxtFile = new StreamReader("INPUT.TXT");
        }
    }
}
