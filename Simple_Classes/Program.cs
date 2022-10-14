// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations.Schema;
using Simple_Classes;

Console.WriteLine("Hello, World!");

Dog dog = new Dog("Васька", "Черный");
dog.Feed(new Fish());
dog.Feed(new Kibble());
