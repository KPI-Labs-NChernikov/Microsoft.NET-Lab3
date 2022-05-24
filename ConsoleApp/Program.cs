// See https://aka.ms/new-console-template for more information
using Backend;
using Backend.Brands.Kropyvnytskyi;

Console.WriteLine("Hello, World!");

var order = new Order();
order.Cement.Material = new KropyvnytskyiFactory().CreateCement();
var mats = order.Materials;
Console.WriteLine();