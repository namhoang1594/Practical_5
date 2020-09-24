using System;
using System.Collections.Generic;
using System.Text;

namespace Books_Management_System
{
    class Book : IBook
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public float AveragePrice { get {return GetAveragePrice ; } }
        public float GetAveragePrice;

        public void Display()
        {
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("Publish Date :" + PublishDate);
            Console.WriteLine("Author :" + Author);
            Console.WriteLine("Language :" + Language);
            Console.WriteLine("Average Price :" + AveragePrice);
        }
        int[] PriceList = new int[5];
        public int this[int index]
        {
            get
            {
                return PriceList[index];
            }
            set
            {
                PriceList[index] = value;
            }
        }
        public void Calculate()
        {
            GetAveragePrice = (float)(PriceList[0] + PriceList[1] + PriceList[2] + PriceList[3] + PriceList[4]) / 5;
        }
    }
}
