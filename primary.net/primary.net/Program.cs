using System;
using System.IO;

namespace primary.net
{
    class Program
    {
        static BinaryWriter sr;
        static ulong numbs = 0;
        static string acc = "";

        static void end()
        {
            File.WriteAllText("writtenNumbers.txt", numbs.ToString());

            sr.Close();
            System.Environment.Exit(1);
        }

        static void flush()
        {
            if(acc.Length > 0)
            {
                int val;

                if (int.TryParse(acc, out val))
                {
                    if (val == 0)
                        end();

                    byte[] bytes = BitConverter.GetBytes(val);

                    if (false)
                    {
                        if (bytes[3] > 0)
                            end();

                        bytes = new byte[] { bytes[0], bytes[1], bytes[2] };
                    }

                    sr.Write(bytes);

                    numbs++;
                    acc = "";
                }
                else
                    end();
            }
        }

        static int fn = 0;
        static string fname;

        static void calcName()
        {
            fn++;
            fname = "primes" + fn + ".txt";
        }


        static void Main(string[] args)
        {
            Console.WriteLine("primes dictionary generator");

            FileStream fs = File.Create("primary.uint");
            sr = new BinaryWriter(fs);

            // https://primes.utm.edu/lists/small/millions/

            calcName();

            while (File.Exists(fname))
            {
                string[] lines = File.ReadAllLines(fname);

                for (int l = 0; l < lines.Length; l++)
                {
                    string line = lines[l];

                    foreach (char c in line)
                    {
                        if (c >= '0' && c <= '9')
                            acc += c;
                        else
                            flush();
                    }

                    flush();

                    if (l > 0 && l % 1000 == 0)
                        Console.WriteLine("First " + l.ToString() + " lines written");
                }

                calcName();
            }

            end();
        }
    }
}
