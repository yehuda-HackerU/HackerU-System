using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerU.DB
{
    public class Cuorse
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public DateTime StartDate {get; set; }
        public int Lessons { get; set; }
        public int Price { get; set; }

        public Cuorse(int id, string name, DateTime startDate, int lessons, int price)
        {
            ID = id;
            Name = name;
            StartDate = startDate;
            Lessons = lessons;
            Price = price;
        }
    }
}
