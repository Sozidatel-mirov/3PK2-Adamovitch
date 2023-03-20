using System;
using System.Numerics;
using P3_5;

P3_5.Plane plane = new P3_5.Plane(13, "Виталик маленький мальчик, будущий мужчина", new Garage(16));
Console.WriteLine(plane);
var plane2 = (P3_5.Plane)plane.Clone();
plane2.Pilot = "Не Виталик,и не мужчина";
plane2.Garage.num = 3338;
Console.WriteLine(plane);
Console.WriteLine();



var tom = new Planetwo(1, "gosha", new Garage(1));
var bob = new Planetwo(2, "bob", new Garage(2));
var sam = new Planetwo(3, "sam", new Garage(1));
Planetwo[] people = { tom, bob, sam };
Array.Sort(people);
foreach (Planetwo person in people)
{
    Console.WriteLine($"{person.Pilot} в гараже {person.Garage}");
}


