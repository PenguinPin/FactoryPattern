using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory
{
    public class AdidasFactory: IClothesFactory
	{
		public AdidasFactory() { }

		public Clothes CeateClothes(ClothesType type)
		{
			Clothes clothes = new Clothes();
			switch (type)
			{
				case ClothesType.Casual:
					clothes = new CasualClothes(ClothesType.Casual);
					break;
				case ClothesType.Cold:
					clothes = new ColdClothes(ClothesType.Cold);
					break;
				case ClothesType.Sport:
					clothes = new SportClothes(ClothesType.Sport);
					break;
				default:
					break;
			}
			
			clothes.Design();
			clothes.Cutting();
			clothes.Suture();
			clothes.Package();
			clothes.GetName();
			return clothes;
		}
	}
}
