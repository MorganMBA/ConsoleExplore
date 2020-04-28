using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Arborescence
{
    public class Explorateur : IExplore
    {
        public Explorateur()
        {


        }

        /// <summary>
        /// returns a list of files in a given directory
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        public List<Element> GetFichiers(Environment.SpecialFolder rep)
        {
            string docPath = Environment.GetFolderPath(rep);
            List<Element> myFiles = new List<Element>();
            DirectoryInfo diTop = new DirectoryInfo(docPath);

            try
            {
                foreach (var fi in diTop.EnumerateFiles())
                {
                    var f = new Fichier(fi.FullName, fi.Length);

                    myFiles.Add(f);
                }
            }
            catch (UnauthorizedAccessException unAuthTop)
            {
                Console.WriteLine($"{unAuthTop.Message}");
            }

            return myFiles;
        }

        /// <summary>
        /// returns a list of repository in a given parent directory
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        public List<Element> GetRepertoires(Environment.SpecialFolder rep)
        {
            string docPath = Environment.GetFolderPath(rep);
            List<Element> myRep = new List<Element>();
            DirectoryInfo diTop = new DirectoryInfo(docPath);

            long taille = 0;

            try
            {
                foreach (var reps in diTop.EnumerateDirectories("*", SearchOption.AllDirectories))
                {
                    foreach (var fi in reps.EnumerateFiles("*", SearchOption.AllDirectories))
                    {
                        taille += fi.Length;
                        var r = new Repertoire(reps.FullName, taille);

                        myRep.Add(r);
                    }
                }
            }
            catch (UnauthorizedAccessException unAuthSubDir)
            {
                Console.WriteLine($"unAuthSubDir: {unAuthSubDir.Message}");
            }

            return myRep;
        }
    }
}
