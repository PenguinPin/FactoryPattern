namespace Factory_Pattern.Factory
{
    public interface IClothesFactory {
        Clothes CeateClothes(ClothesType type);
    }


    public enum ClothesType
    { 
        Casual,
        Cold,
        Sport
    }
}
