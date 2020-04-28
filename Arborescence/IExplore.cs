using System;
using System.Collections.Generic;
using System.Text;

namespace Arborescence
{
    public interface IExplore
    {
        /// <summary>
        /// returns a list of files in a given directory
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        List<Element> GetFichiers(Environment.SpecialFolder rep);

        /// <summary>
        /// returns a list of repository in a given parent directory
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        List<Element> GetRepertoires(Environment.SpecialFolder rep);
    }
}
