using System;
using System.Collections.Generic;
using System.Text;

namespace Books_Management_System
{
    interface IBook
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public float AveragePrice { get; }

        void Display();
    }
}
