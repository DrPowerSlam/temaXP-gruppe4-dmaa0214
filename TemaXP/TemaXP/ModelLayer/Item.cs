using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemaXP.ModelLayer
{
    public class Item
    {
        // default "Ukendt"
        public String Author { get; set; }

        public String Title { get; set; }
        public int Year { get; set; }

        // 4 ciphers
        public int ID { get; set; }
        [Index (IsUnique = true), Range(1000, 9999)]
        public int Number { get; set; }
        public String Description { get; set; }
        public double PurchasePrice { get; set; }
        public int Interval { get; set; }
        public String Image { get; set; }
        public double MinPrice { get; set; }

        // Perhaps unneeded
        public bool Sold { get; set; }

        public Item()
        {
            Author = "Ukendt";
        }

        public Item(int number, string author, string title, int year,
            string description, double purchasePrice, int interval,
            string image, double minPrice)
        {
            Number = number;
            Author = author;
            Title = title;
            Year = year;
            Description = description;
            PurchasePrice = purchasePrice;
            Interval = interval;
            Image = image;
            MinPrice = minPrice;

            Sold = false;
        }
    }
}