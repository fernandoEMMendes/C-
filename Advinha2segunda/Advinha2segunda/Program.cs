using System.ComponentModel;
using System.Diagnostics;

int vida2 = 300;
int vida1 = 100;
int pocao = 3;
int dmg1 = 0;
int dmg2 = 0;

int healActive = 0;

do {
    Console.Clear();

    Console.WriteLine("\n\n");
    if (dmg1 != 0 || dmg2 != 0) { Console.WriteLine($"\t\t -{dmg2} \t\t\t\t   -{dmg1}"); dmg1 = 0; dmg2 = 0; }
    if (healActive == 1) { Console.WriteLine("\t\t +25"); healActive = 0; }

    Console.WriteLine($"\tvida: {vida1} \t\t\tchefão: {vida2}");
    Console.WriteLine($"\n\tA = ataque");
    Console.WriteLine($"\t  D = poção({pocao} restantes)");

    ConsoleKeyInfo key = Console.ReadKey();

    if (key.Key == ConsoleKey.A)
    {
        /*
        Attack();
        EnemyAttack();
        vida1 = vida1 - dmg2;
        vida2 = vida2 - dmg1;
        */
    }
    
    else if (key.Key == ConsoleKey.D)
    {
        if (pocao > 0 && vida1 < 100)
        {
            Heal();
        } else
        {
            continue;
        }
    }

    if (vida1 <= 0) { vida1 = 0; Console.Clear(); Console.WriteLine("\n\n\t\tvocê perdeu!"); break; }
    if (vida2 <= 0) { vida2 = 0; Console.Clear(); Console.WriteLine("\n\n\t\tvocê ganhou!"); break; }
   
} while (vida1 > 0 || vida2 > 0);

int EnemyAttack()
{
    Random n2 = new Random();
    dmg2 = Convert.ToInt32(n2.Next(1, 5));
    return dmg2;
}

int Attack()
{
    Random n1 = new Random();
    dmg1 = Convert.ToInt32(n1.Next(1, 10));
    return dmg1;
}

int Heal()
{
    pocao--;
    vida1 = vida1 + 25;
    if (vida1 > 100)
    {
        vida1 = 100;
    }
    healActive = 1;
    return vida1;
}