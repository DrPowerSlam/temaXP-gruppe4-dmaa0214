using System;

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

        public Item(string author, string title, int year,
            string description, double purchasePrice, int interval,
            string image, double minPrice)
        {
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