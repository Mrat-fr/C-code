using System;
class MainClass {
// The base Hero class
class Hero{
public string name = "Handle";
public string desc = "Info";
public int level = 25;
 
//adding a function to show polymorphism
public virtual void HeroSound() //notice the virtual keyword
{
Console.WriteLine("\nThe Hero shouts");
}
}
//A class the inherits from the Hero class
class mage : Hero{
public int abilitypower;
//polymorphism notice the override keyword
public override void HeroSound()
{
Console.WriteLine("\nThe mage casts: fire ball");
}
}
//another class that takes info from the main hero class
class assassin : Hero{
public int crit;
 
public override void HeroSound()
{
Console.WriteLine("\nThe assassin casts: dagger throw");
}
 
}
 
public static void Main (string[] args) {
 
//declaring a new instance of a main Hero class and printing out the base stats
Hero gigi = new Hero();
Console.WriteLine(gigi.name);
gigi.desc = "a char description";
Console.WriteLine(gigi.desc);
gigi.level = 5;
Console.WriteLine(gigi.level);
 
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a assassin class using vars from both classes
assassin slooth = new assassin();
slooth.name = "Ash";
Console.WriteLine(slooth.name);
slooth.desc = "hides in the shadows";
Console.WriteLine(slooth.desc);
slooth.level = 15;
Console.WriteLine(slooth.level);
 
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a mage class using vars from both classes
mage chad = new mage();
chad.name = "Swift";
Console.WriteLine(chad.name);
chad.desc = "hurdles fire and ice";
Console.WriteLine(chad.desc);
chad.level = 15;
Console.WriteLine(chad.level);
chad.abilitypower = 10;
Console.WriteLine(chad.abilitypower);
 
 
//calling the same function from each class and seeing the difference
gigi.HeroSound();
slooth.HeroSound();
chad.HeroSound();
}
 
}
