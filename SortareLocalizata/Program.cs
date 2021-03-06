﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortareLocalizata
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista = new List<Persoane>();
            using (StreamReader str = new StreamReader(@"..\..\input.txt"))
            {
                string line;
                while ((line = str.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '-');
                    var persona = new Persoane(words[0], words[1]);
                    Lista.Add(persona);
                }
                Lista.Sort(delegate (Persoane x, Persoane y)
               { 
                   int  a = x.prenume.CompareTo(y.prenume);
                    a = x.nume.CompareTo(y.nume);
                    return a;
                });

            }
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                foreach (var item in Lista)
                {
                    writer.WriteLine(item.nume + " " + item.prenume);
                }
            }
        }
    }
}
