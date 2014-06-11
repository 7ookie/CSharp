using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace parsesAnURL
{
    class parsesAnURL
    {
        static void Main(string[] args)
        {
            //string hint = Console.ReadLine();
            string address = "http://www.devbg.org/forum/index.php";
            //Console.WriteLine(ExtractFromURL(hint));
            StringBuilder protocol = new StringBuilder();
            StringBuilder adr = new StringBuilder();
            StringBuilder path = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i].ToString() == ":")
                {
                    break;
                }
                protocol.Append(address[i]);
            }
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i].ToString() == "/")
                {
                    if (counter == 1)
                    {
                        for (int z = i + 1; z < address.Length - 1; z++)
                        {
                            if (address[z].ToString() == "/")
                            {
                                break;
                            }
                            adr.Append(address[z]);
                        }
                    }
                    counter++;
                    if (counter == 3)
                    {
                        for (int w = i; w < address.Length; w++)
                        {
                            path.Append(address[w]);
                        }

                    }
                }
            }
            Console.WriteLine("protocol - {0}", protocol);
            Console.WriteLine("server - {0}", adr);
            Console.WriteLine("resource - {0}", path);
        }
        /*
        static string ExtractFromURL(string address)
        {
            StringBuilder protocol = new StringBuilder();
            StringBuilder adr = new StringBuilder();
            StringBuilder path = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i].ToString() == ":")
                {
                    break;
                }
                protocol.Append(address[i]);
            }
            for (int i = 0; i < address.Length; i++)
            {
                if (address[i].ToString() == "/")
                {
                    if (counter == 1)
                    {
                        for (int z = i + 1; z < address.Length - 1; z++)
                        {
                            if (address[z].ToString() == "/")
                            {
                                break;
                            }
                            adr.Append(address[z]);
                        }
                    }
                    counter++;
                    if (counter == 3)
                    {
                        for (int w = i; w < address.Length; w++)
                        {
                            path.Append(address[w]);
                        }
                        
                    }
                }
            }
            return path.ToString();
        }
        */
    }
}
