using Arborescence;
using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arborescence par Morgan MBA  \n");

            var app = new Explorateur();
            var ConsoleL = new ConsoleList();

            List<Element> files = app.GetFichiers(Environment.SpecialFolder.MyDocuments);
            List<Element> repos = app.GetRepertoires(Environment.SpecialFolder.MyDocuments);

            ConsoleL.ConsoleListFileOrRepertoire(files);
            ConsoleL.ConsoleListFileOrRepertoire(repos);

            Console.ReadKey();
        }
    }
}
