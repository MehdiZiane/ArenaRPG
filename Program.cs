using ArenaRPG.Models;
using ArenaRPG.Services;
using ArenaRPG.Utils;

Console.WriteLine("Bienvenue dans l arene");

Personnage perso = new Personnage();
perso.Nom = "";
perso.PointsDeVie = 100;
perso.Force = 4;
perso.Mana = -60;

Console.WriteLine($"{perso.Nom} a {perso.PointsDeVie} PV avec {perso.Force} de force et {perso.Mana} de mana ");

//perso.Niveau = 5;
Console.WriteLine($"niveau : {perso.Niveau} toujour vivant : {perso.EstVivant}");

Personnage p2 = new Personnage { Nom = "Aldric" };
Personnage p3 = new Personnage { Nom = "Elowen" };
p3.MonterDeNiveau();

Console.WriteLine(p2 == p3);
Console.WriteLine(p2 < p3);
Console.WriteLine(p2 > p3);
Console.WriteLine(p2.Equals(p3));

Personnage p4 = new Personnage("Thorin", 150, 12, 20);
Personnage p5 = new Personnage("Elowen");
Personnage p6 = new Personnage();
Console.WriteLine($"{p4.Nom} : {p4.PointsDeVie} PV, niveau {p4.Niveau}");
Console.WriteLine($"{p5.Nom} : {p5.PointsDeVie} PV, niveau {p5.Niveau}");
Console.WriteLine($"{p6.Nom} : {p6.PointsDeVie} PV, niveau {p6.Niveau}");
Console.WriteLine(new Personnage("Test", -10, 5, 5).PointsDeVie);

JournalCombat journal = new JournalCombat("combat.log");
journal.Ecrire("Aldric attaque Elowen");
journal.Ecrire("Elowen perd 10 PV");

Console.WriteLine($"Personnages créés : {Personnage.NombreDePersonnages}");
Console.WriteLine($"Niveau max : {Personnage.NiveauMax}");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Lancer d6 : {Des.Lancer(6)}");
}

for (int i = 0; i < 60; i++)
{
    p3.MonterDeNiveau();
}
Console.WriteLine(p3.Niveau);   // que doit-il afficher ?
