using Factory_Pattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class CasualClothes : Clothes
    {
        public ClothesType type { get; set; }
        public CasualClothes(ClothesType name)
        {
            type = name;
            Product = "休閒衣服";
			Style = "休閒風";
			Material = "柔軟材質";
			Color = "黑色";

		}

	}
}
