using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labform1
{
    class item
    {
        private static List<item> items = new List<item>();
        public int Number { get; set; }

        public string Date { get; set; }

        public int Inventorynum { get; set; }

        public string Objectname { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }

        public bool isAvailable { get; set; }


        public bool isSimple { get; set; }
        public bool isVariable { get; set; }



        public void Save()
        {
            items.Add(this);
            //  Console.WriteLine("SAVED");
        }
        static public List<item> getAll()
        {
            return items;
        }
    }
}
