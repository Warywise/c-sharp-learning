Random dice = new Random();
int heroHp = 10;
int monsterHp = 10;

Console.WriteLine("#>>> RPG de combate <<<#");
Console.WriteLine("Olá aventureiro! Primeiro preciso saber como se chama o herói que nos livrará do mal.");
Console.Write("Qual o nome do seu personagem? ");
string player = Console.ReadLine();
Console.WriteLine($"Olá {player}! Seja bem-vindo ao RPG de combate! Seu personagem tem {heroHp} pontos de vida e enfrentará um monstro aleatório.\n");

string[] monsters = ["Goblin", "Orc", "Troll", "Minotauro", "Dragão"];
string monsterName = monsters[dice.Next(0, monsters.Length)];
int monsterMaxDmg = 1;

Console.WriteLine("Você encontra uma porta na masmorra. Que perigos podem estar por trás dela? Deseja abri-la? (Sim / Não)");
string openDoor = Console.ReadLine();

if (openDoor.Trim().ToLower() == "s" || openDoor.Trim().ToLower() == "sim")
{
  Console.WriteLine("Você decide abrir a porta e...\n");
}
else
{
  Console.WriteLine("Você decide não abrir a porta e voltar para a cidade. Sua jornada se finda antes mesmo de começar.");

  Console.WriteLine("\n#FIM!#");
  return;
}


switch (monsterName)
{
  case "Goblin":
    Console.WriteLine("Um Goblin apareceu! Parece que é seu dia de sorte.");
    monsterMaxDmg = 2;
    break;
  case "Orc":
    Console.WriteLine("Um Orc apareceu! Prepare-se para a batalha.");
    monsterMaxDmg = 4;
    break;
  case "Troll":
    Console.WriteLine("Um Troll apareceu! Esta será a sua provação.");
    monsterMaxDmg = 6;
    break;
  case "Minotauro":
    Console.WriteLine("Um Minotauro apareceu! Que os deuses estejam ao seu lado nobre guerreiro.");
    monsterMaxDmg = 8;
    break;
  case "Dragão":
    Console.WriteLine("Que aura temível! Não é possível... Um Dragão apareceu! Que os deuses tenham piedade de nós.");
    monsterMaxDmg = 10;
    monsterHp = 20;
    break;
}

Console.WriteLine("Prepare-se para a batalha!\n");
Thread.Sleep(5000);

do
{
  int heroDmg = dice.Next(1, 11);
  int monsterDmg = dice.Next(1, monsterMaxDmg + 1);

// TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou fugir
// TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou usar um item
// TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou usar uma habilidade especial
// TODO: Implementar lógica para permitir que o jogador ataque primeiro

  heroHp -= monsterDmg > heroHp ? heroHp : monsterDmg;
  monsterHp -= heroDmg > monsterHp ? monsterHp : heroDmg;

  Console.WriteLine($"O {monsterName} ataca e causa {monsterDmg} de dano. {player} agora tem {heroHp} pontos de vida.");

  if (heroHp <= 0)
    break;

  Console.WriteLine($"{player} ataca e causa {heroDmg} de dano. O {monsterName} agora tem {monsterHp} pontos de vida.\n");

  Thread.Sleep(3000);

} while (heroHp > 0 && monsterHp > 0);

Console.WriteLine(heroHp > monsterHp ? $"\n\nParabéns {player}! Você derrotou o {monsterName}." : $"O {monsterName} derrotou {player}.");

if (monsterName == "Dragão" && heroHp > 0)
  Console.WriteLine("Você é um verdadeiro herói! Sua lenda será contada e cantada por gerações.");

Console.WriteLine("\n#FIM!#");
