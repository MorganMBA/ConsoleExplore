using System;
using System.Collections.Generic;
using System.Text;

namespace Arborescence
{
    public class ConsoleList
    {
        /// <summary>
        /// Log the names of the directories or files in a list of directories or files
        /// </summary>
        /// <param name="elmt"></param>
        public void ConsoleListFileOrRepertoire(List<Element> elmt)
        {
            foreach (var fi in elmt)
            {
                Console.WriteLine($"{fi.Nom}\t\t{fi.Taille}");
            }
        }
    }
}
