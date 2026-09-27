using ArenaRPG.Models;

Console.WriteLine("Bienvenue dans l arene");

Personnage perso = new Personnage();
perso.Nom = "";
perso.PointsDeVie = 100;
perso.Force = 4;
perso.Mana = -60;

Console.WriteLine($"{perso.Nom} a {perso.PointsDeVie} PV avec {perso.Force} de force et {perso.Mana} de mana ");

//perso.Niveau = 5;
Console.WriteLine($"niveau : {perso.Niveau} toujour vivant : {perso.EstVivant}");



