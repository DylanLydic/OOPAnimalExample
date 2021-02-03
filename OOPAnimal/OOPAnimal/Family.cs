using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAnimal
{
    class Family
    {
        public string Name;
        public int numberofToes;
        public int numberofTeeth;
        public bool whiskers;
        public bool doesJeremyLikeIt;
        public Family(string _name = null)
        {
            Name = _name;
            Console.WriteLine(" Creating " + _name + " at " + DateTime.Now.ToString("yyyy-MM-dd"));
         }

        public void setAttributes(Family sentFamily)
        {
            numberofTeeth = sentFamily.numberofTeeth;
            numberofToes = sentFamily.numberofToes;
        }

        public bool doesJermeyLikeThisFamily()
        {
            return doesJeremyLikeIt;
        }

    }
}
