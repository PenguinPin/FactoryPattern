using Factory_Pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Clothes
    {
        public string Product;
        public string Style;
        public string Material;
        public string Color;
        ClothesType type { get; set; }

        public void Design()
        {
            Console.WriteLine("設計樣板");
        }

        public void Cutting()
        {
            Console.WriteLine("裁切衣服");
        }

        public void Suture()
        {
            Console.WriteLine("縫合");
        }

        public void Package()
        {
            Console.WriteLine("包裝");
        }

        public string GetName()
        {
			Console.WriteLine(Product);
			return Product;
        }
    }
}
