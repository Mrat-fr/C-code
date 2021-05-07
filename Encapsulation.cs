using System;
class MainClass {
// The base Hero class
class Hero{
public string name = "league of legends champion";
public string desc = "Champ stats";
private int level;
//encapsulation of the level var
public int charLevel {
 
get //getter and setters for the char level
{
return level;
}
 
set
{
level = value;
}
 
}
 
//adding a function to show polymorphism
public virtual void ChampAction() //notice the virtual keyword
{
Console.WriteLine("\nThe champ does something");
}
}
//A class the inherits from the Hero class
class Marksman : Hero{
public int Damage;
public int Control;
public int Utility;
public int Mobility;
public int Toughness;
 
//polymorphism notice the override keyword
public override void ChampAction()
{
Console.WriteLine("\nThe Marksman uses stun");
}
}
//another class that takes info from the main hero class
class Juggernaut : Hero{
public int Damage;
public int Control;
public int Utility;
public int Mobility;
public int Toughness;
public override void ChampAction()
{
Console.WriteLine("\nThe Juggernaut uses shiled");
}
}
 
//another class that takes info from the main hero class
class Diver : Hero{
public int Damage;
public int Control;
public int Utility;
public int Mobility;
public int Toughness;
public override void ChampAction()
{
Console.WriteLine("\nThe Diver uses dash");
}
}
 
public static void Main (string[] args) {
 
//declaring a new instance of a main Hero class and printing out the base stats
Diver gigi = new Diver();
gigi.name = "Wukong";
Console.WriteLine(gigi.name);
gigi.desc = "Wukong is a vastayan trickster who uses his strength, agility, and intelligence to confuse his opponents and gain the upper hand. After finding a lifelong friend in the warrior known as Master Yi, Wukong became the last student of the ancient martial art known as Wuju. Armed with an enchanted staff, Wukong seeks to prevent Ionia from falling to ruin.";
Console.WriteLine(gigi.desc);
gigi.charLevel = 15;//using charLevel instead of level becuase level is private
Console.WriteLine(gigi.charLevel);
gigi.Damage = 2;
gigi.Control = 2;
gigi.Utility = 1;
gigi.Mobility = 2;
gigi.Toughness = 2;
Console.WriteLine(gigi.Damage);
Console.WriteLine(gigi.Control);
Console.WriteLine(gigi.Utility);
Console.WriteLine(gigi.Mobility);
Console.WriteLine(gigi.Toughness);
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a Marksman class using vars from both classes
Marksman slooth = new Marksman();
slooth.name = "Ashe";
Console.WriteLine(slooth.name);
slooth.desc = "Iceborn warmother of the Avarosan tribe, Ashe commands the most populous horde in the north. Stoic, intelligent, and idealistic, yet uncomfortable with her role as leader, she taps into the ancestral magics of her lineage to wield a bow of True Ice. With her people's belief that she is the mythological hero Avarosa reincarnated, Ashe hopes to unify the Freljord once more by retaking their ancient, tribal lands.";
Console.WriteLine(slooth.desc);
slooth.charLevel = 10;
Console.WriteLine(slooth.charLevel);//using charLevel instead of level becuase level is private
slooth.Damage = 2;
slooth.Control = 5;
slooth.Utility = 2;
slooth.Mobility = 1;
slooth.Toughness = 1;
Console.WriteLine(slooth.Damage);
Console.WriteLine(slooth.Control);
Console.WriteLine(slooth.Utility);
Console.WriteLine(slooth.Mobility);
Console.WriteLine(slooth.Toughness);
 
 
 
Console.WriteLine("\n ---------------------------------- \n");
//an instance of a Juggernaut class using vars from both classes
Juggernaut chad = new Juggernaut();
chad.name = "Darius";
Console.WriteLine(chad.name);
chad.desc = "There is no greater symbol of Noxian might than Darius, the nation's most feared and battle-hardened commander. Rising from humble origins to become the Hand of Noxus, he cleaves through the empire's enemies—many of them Noxians themselves. Knowing that he never doubts his cause is just, and never hesitates once his axe is raised, those who stand against the leader of the Trifarian Legion can expect no mercy.";
Console.WriteLine(chad.desc);
chad.charLevel = 13;
Console.WriteLine(chad.charLevel);//using charLevel instead of level becuase level is private
chad.Damage = 5;
chad.Control = 2;
chad.Utility = 1;
chad.Mobility = 1;
chad.Toughness = 2;
Console.WriteLine(chad.Damage);
Console.WriteLine(chad.Control);
Console.WriteLine(chad.Utility);
Console.WriteLine(chad.Mobility);
Console.WriteLine(chad.Toughness);
 
 
 
 
//calling the same function from each class and seeing the difference
gigi.ChampAction();
slooth.ChampAction();
chad.ChampAction();
}
 
}
