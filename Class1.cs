using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labform1
{
    class item
    {
        public int Number { get; set; }

        public string Date { get; set; }

        public int Inventorynum { get; set; }

        public string Objectname { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }

        

        public void Save()
        {
            Console.WriteLine("SAVED");
        }
    }
}
