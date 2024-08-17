Random dice = new Random();
int heroHp = 10;
int monsterHp = 10;
string winner = "";

Console.WriteLine("#>>> RPG de combate <<<#");
Console.WriteLine("Olá aventureiro! Primeiro preciso saber como se chama o herói que nos livrará do mal.");
Console.Write("Qual o nome do seu personagem? ");
string player = Console.ReadLine();
Console.WriteLine($"Olá {player}! Seja bem-vindo ao RPG de combate! Seu personagem tem {heroHp} pontos de vida e enfrentará um monstro aleatório.\n");

string[] monsters = ["Goblin", "Orc", "Troll", "Minotauro", "Dragão"];
string monsterName = monsters[dice.Next(0, monsters.Length)];
int monsterMaxDmg = 1;
int heroMaxDmg = 10;

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
    monsterMaxDmg = 7;
    break;
  case "Dragão":
    Console.WriteLine("Que aura temível! Não é possível... Um Dragão apareceu! Que os deuses tenham piedade de nós.");
    monsterMaxDmg = 10;
    monsterHp = 20;
    break;
}

Console.WriteLine("Prepare-se para a batalha!\n");
Thread.Sleep(5000);

// TODO: Implementar lógica para "iniciativa" (quem tem mais chance de atacar primeiro)
ActionOrder actionOrder = GetActionOrder(
  new Entity(player, heroHp, heroMaxDmg, dice.Next(1, 7)),
  new Entity(monsterName, monsterHp, monsterMaxDmg, dice.Next(1, 7))
  );

Entity firstEntity = actionOrder.FirstEntity;
Entity secondEntity = actionOrder.SecondEntity;

do
{
  int firstDmg = dice.Next(1, firstEntity.MaxDmg + 1);
  int secondDmg = dice.Next(1, secondEntity.MaxDmg + 1);

  // TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou fugir
  // TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou usar um item
  // TODO: Implementar lógica para permitir que o jogador escolha entre atacar ou usar uma habilidade especial

  secondEntity.Hp -= firstDmg > secondEntity.Hp ? secondEntity.Hp : firstDmg;

  Console.WriteLine($"{firstEntity.Name} ataca e causa {firstDmg} de dano. {secondEntity.Name} agora tem {secondEntity.Hp} pontos de vida.");

  if (secondEntity.Hp <= 0)
    winner = firstEntity.Name;
    break;

  firstEntity.Hp -= secondDmg > firstEntity.Hp ? firstEntity.Hp : secondDmg;

  Console.WriteLine($"{secondEntity.Name} ataca e causa {secondDmg} de dano. {firstEntity.Name} agora tem {firstEntity.Hp} pontos de vida.\n");

  Thread.Sleep(3000);

  if (firstEntity.Hp <= 0)
    winner = secondEntity.Name;
    break;

} while (firstEntity.Hp > 0 && secondEntity.Hp > 0);

Console.WriteLine($"{firstEntity.Name} {(firstEntity.Hp > 0 ? "derrotou" : "foi derrotado por")} {secondEntity.Name}.");

if (monsterName == "Dragão" && winner == player)
  Console.WriteLine("Você é um verdadeiro herói! Sua lenda será contada e cantada por gerações.");

Console.WriteLine("\n#FIM!#");

/*
  Função GetActionOrder: Recebe duas entidades como parâmetro, compara as rolagens de dado e retorna a ordem correta em um objeto do tipo ActionOrder.
*/
ActionOrder GetActionOrder(Entity entity1, Entity entity2)
{
  if (entity1.Roll >= entity2.Roll)
  {
    return new ActionOrder
    {
      FirstEntity = entity1,
      SecondEntity = entity2
    };
  }
  else
  {
    return new ActionOrder
    {
      FirstEntity = entity2,
      SecondEntity = entity1
    };
  }
}

/*
  Classe Entity: Representa uma entidade no jogo, contendo propriedades para o nome, HP e a rolagem do dado.
*/
public class Entity
{
  public string Name { get; set; }
  public int Hp { get; set; }
  public int MaxDmg { get; set; }
  public int Roll { get; set; }

  public Entity(string name, int hp, int maxDmg, int roll)
  {
    Name = name;
    Hp = hp;
    MaxDmg = maxDmg;
    Roll = roll;
  }
}

/*
  Classe ActionOrder: Serve como o "objeto", contendo as entidades em ordem de ação.
*/
public class ActionOrder
{
  public Entity FirstEntity { get; set; }
  public Entity SecondEntity { get; set; }
}
