using ArenaRPG.Models;
using ArenaRPG.Services;

Console.WriteLine("Bienvenue dans l arene");

Personnage perso = new Personnage();
perso.Nom = "";
perso.PointsDeVie = 100;
perso.Force = 4;
perso.Mana = -60;

Console.WriteLine($"{perso.Nom} a {perso.PointsDeVie} PV avec {perso.Force} de force et {perso.Mana} de mana ");

//perso.Niveau = 5;
Console.WriteLine($"niveau : {perso.Niveau} toujour vivant : {perso.EstVivant}");

Personnage p3 = new Personnage { Nom = "Aldric" };
Personnage p4 = new Personnage { Nom = "Elowen" };
p4.MonterDeNiveau();

Console.WriteLine(p3 == p4);
Console.WriteLine(p3 < p4);
Console.WriteLine(p3 > p4);
Console.WriteLine(p3.Equals(p4));

Personnage p5 = new Personnage("Thorin", 150, 12, 20);
Personnage p6 = new Personnage("Elowen");
Personnage p7 = new Personnage();
Console.WriteLine($"{p5.Nom} : {p5.PointsDeVie} PV, niveau {p5.Niveau}");
Console.WriteLine($"{p6.Nom} : {p6.PointsDeVie} PV, niveau {p6.Niveau}");
Console.WriteLine($"{p7.Nom} : {p7.PointsDeVie} PV, niveau {p7.Niveau}");
Console.WriteLine(new Personnage("Test", -10, 5, 5).PointsDeVie);

JournalCombat journal = new JournalCombat("combat.log");
journal.Ecrire("Aldric attaque Elowen");
journal.Ecrire("Elowen perd 10 PV");

