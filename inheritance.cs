using System;
class MainClass {
// The base Hero class
class Hero{
public string name = "pink";
public string desc = "Basic description";
public int level = 5;
}
//A class the inherits from the Hero class
class Rouge : Hero{
public int size = 10;
}
//another class that takes info from the main hero class
class Tank : Hero{
public int Strength = 15;
}
 
public static void Main (string[] args) {
Console.WriteLine("\n ---------------------------------- \n");
//declaring a new instance of a main Hero class and printing out the base stats
Hero gigi = new Hero();
Console.WriteLine(gigi.name);
gigi.desc = "looks cool";
Console.WriteLine(gigi.desc);
gigi.level = 79;
Console.WriteLine(gigi.level);
 
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a rouge class using vars from both classes
Rouge slooth = new Rouge();
slooth.name = "dog";
Console.WriteLine(slooth.name);
slooth.desc = "This dog is huge";
Console.WriteLine(slooth.desc);
slooth.level = 99;
Console.WriteLine(slooth.level);
 
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a Tank class using vars from both classes
Tank chad = new Tank();
chad.name = "Mrat";
Console.WriteLine(chad.name);
chad.desc = "cool black man";
Console.WriteLine(chad.desc);
chad.level = 13;
Console.WriteLine(chad.level);
Console.WriteLine("\n ---------------------------------- \n");
 
 
}
 
}
