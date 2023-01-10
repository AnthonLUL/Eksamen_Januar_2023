using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WoodPalletsLib
{
    public class WododPallet
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public int Price { get; set; }

        public int Quality { get; set; }

        public WododPallet(int id, string brand, int price, int quality)
        {
            Id = id;
            Brand = brand;
            Price = price;
            Quality = quality;
        }

        public WododPallet()
        {

        }

        public override string ToString()
        {
            return $"Id = {Id}, Brand = {Brand}, Price = {Price}, Quality = {Quality}";
        }
    }
}
