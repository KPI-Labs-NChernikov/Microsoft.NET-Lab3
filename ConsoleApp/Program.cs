// See https://aka.ms/new-console-template for more information
using Backend;
using Backend.Brands.Kropyvnytskyi;

Console.WriteLine("Hello, World!");

var order = new Order();
order.Cement.Material = new KropyvnytskyiFactory().CreateCement();
order.Cement.Demand = 1000;
var mats = order.Materials;
Console.WriteLine($"{order.MinDeliveryTime.Days} days {order.MinDeliveryTime.Hours} hours");
Console.WriteLine(order.Cement.Material);