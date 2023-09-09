// See https://aka.ms/new-console-template for more information
using Factory_Pattern;
using Factory_Pattern.Factory;

var nikeStore = new NikeFactory();
var adidasStore = new AdidasFactory();

Console.WriteLine("Nike廠商");
Clothes clothes = nikeStore.CeateClothes(ClothesType.Cold);
//Console.WriteLine($"出貨:{nikeStore.}");

Console.WriteLine("Adidas廠商");
clothes = adidasStore.CeateClothes(ClothesType.Sport);
//Console.WriteLine($"出貨:{clothes.GetName()}");


