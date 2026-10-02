using ArenaRPG.Interfaces;
using ArenaRPG.Models;
using ArenaRPG.Services;
using ArenaRPG.Utils;

Console.WriteLine("Bienvenue dans l arene");

Personnage perso = new Mannequin();
perso.Nom = "";
perso.PointsDeVie = 100;
perso.Force = 4;
perso.Mana = -60;

Console.WriteLine($"{perso.Nom} a {perso.PointsDeVie} PV avec {perso.Force} de force et {perso.Mana} de mana ");

//perso.Niveau = 5;
Console.WriteLine($"niveau : {perso.Niveau} toujour vivant : {perso.EstVivant}");

Personnage p2 = new Mannequin { Nom = "Aldric" };
Personnage p3 = new Mannequin { Nom = "Elowen" };
p3.MonterDeNiveau();

Console.WriteLine(p2 == p3);
Console.WriteLine(p2 < p3);
Console.WriteLine(p2 > p3);
Console.WriteLine(p2.Equals(p3));

Personnage p4 = new Mannequin("Thorin", 150, 12, 20);
Personnage p5 = new Mannequin("Elowen");
Personnage p6 = new Mannequin();
Console.WriteLine($"{p4.Nom} : {p4.PointsDeVie} PV, niveau {p4.Niveau}");
Console.WriteLine($"{p5.Nom} : {p5.PointsDeVie} PV, niveau {p5.Niveau}");
Console.WriteLine($"{p6.Nom} : {p6.PointsDeVie} PV, niveau {p6.Niveau}");
Console.WriteLine(new Mannequin("Test", -10, 5, 5).PointsDeVie);

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

Guerrier guerrier = new Guerrier("Thorin", 150, 20, 5);
Mage mage = new Mage("Elara", 90, 8, 30);
Archer archer = new Archer("Lysandre", 100, 15, 10);

Personnage cible = new Mannequin("MannequinDEntrainement", 200, 0, 0);

guerrier.Attaquer(cible);
Console.WriteLine($"Après attaque Guerrier : {cible.PointsDeVie} PV");

mage.Attaquer(cible);
Console.WriteLine($"Après attaque Mage : {cible.PointsDeVie} PV");

archer.Attaquer(cible);
Console.WriteLine($"Après attaque Archer : {cible.PointsDeVie} PV");

List<Personnage> equipe = new List<Personnage>();
equipe.Add(guerrier);
equipe.Add(mage);
equipe.Add(archer);

foreach(Personnage p in equipe)
{
    p.Attaquer(cible);
    if (p is Mage m)
    {
        Console.WriteLine($"{m.Nom} a attaqué {cible.Nom} avec une magie de type {m.TypeMagie}  il lui reste {cible.PointsDeVie} pv");
    }
    else
    {
        Console.WriteLine($"{p.Nom} a attaqué {cible.Nom} a {cible.PointsDeVie} pv restant");
    }
}

foreach (Personnage p in equipe)
{
    Console.WriteLine(p.DecrireCompetence());
}

guerrier.Attaquer(mage);
Console.WriteLine($"point de vie du mage {mage.PointsDeVie} pv");
mage.Soigner(20);
Console.WriteLine($"le mage c est soigné il a {mage.PointsDeVie} pv");

archer.Empoisonner(5, 3);
Console.WriteLine($"Empoisonné : {archer.EstEmpoisonne}");

archer.AppliquerPoison();
Console.WriteLine($"Après tour 1 : {archer.PointsDeVie} PV, toujours empoisonné : {archer.EstEmpoisonne}");

archer.AppliquerPoison();
Console.WriteLine($"Après tour 2 : {archer.PointsDeVie} PV, toujours empoisonné : {archer.EstEmpoisonne}");

archer.AppliquerPoison();
Console.WriteLine($"Après tour 3 : {archer.PointsDeVie} PV, toujours empoisonné : {archer.EstEmpoisonne}");

archer.AppliquerPoison();
Console.WriteLine($"Après tour 4 (ne devrait plus rien faire) : {archer.PointsDeVie} PV");

Mage magesoins = new Mage("tyli", 150, 5, 25);

List<ISoignable> soignables = new List<ISoignable>();
soignables.Add(mage);
soignables.Add(magesoins);

foreach(ISoignable s in soignables)
{
    s.Soigner(10);
}

Console.WriteLine($"pv apres s etre soigné de {mage.PointsDeVie} {magesoins.PointsDeVie}");

Arme arme = new Arme("épée", 20);
guerrier.Equiper(arme);

Personnage cibletest = new Mannequin("cibletest", 200, 0, 0);
guerrier.Attaquer(cibletest);
Console.WriteLine($"le guerrier a attaqué avec une arme, {cibletest.Nom} a {cibletest.PointsDeVie} pv");

guerrier.Inventaire.Ajouter("Potion de soin");
guerrier.Inventaire.Ajouter("Parchemin");
guerrier.Inventaire.Ajouter("Torche");
guerrier.Inventaire.Ajouter("Corde");
guerrier.Inventaire.Ajouter("Bouclier");
bool ajoutReussi = guerrier.Inventaire.Ajouter("Épée supplémentaire");   // capacité dépassée
Console.WriteLine($"Ajout du 6e objet réussi : {ajoutReussi}");

guerrier.Inventaire.AfficherContenu();