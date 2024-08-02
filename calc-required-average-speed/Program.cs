// ENTRADA DE DADOS
// Método ReadLine() é utilizado para ler a entrada do usuário
Console.WriteLine("Boas vindas ao programa 'Calcula Velocidade'!");
Console.WriteLine("Primeiramente, qual o seu nome?");
// Para strings não é necessário converter o tipo
string name = Console.ReadLine();
Console.WriteLine("Olá, " + name + "! Vamos calcular a velocidade média necessária para percorrer uma distância em um determinado tempo. Para isso, precisaremos de alguns dados.");

Console.WriteLine("Para continuar, digite: OK");
string userResponse= Console.ReadLine();

if (userResponse != null && userResponse.ToUpper() != "OK")
{
  Console.WriteLine("Encerrando o programa...");
  return;
}

Console.WriteLine("Informe a distância a ser percorrida em quilômetros: ");
decimal distance = decimal.Parse(Console.ReadLine());

// TODO: Verificar possibilidade de aguardar um tempo em segundos até próxima execução

Console.WriteLine("Escolha a unidade de tempo para o cálculo da velocidade média:");
Console.WriteLine("Digite \" 1 \", para Minutos");
Console.WriteLine("Digite \" 2 \", para Horas");
int timeUnit = int.Parse(Console.ReadLine());

if (timeUnit != 1 && timeUnit != 2)
{
  // TODO: implementar lógica para repetir o fluxo de escolha da unidade de tempo
  Console.WriteLine("Opção inválida. Encerrando o programa...");
  return;
}

Console.WriteLine("Informe o tempo disponível para percorrer essa distância: ");
decimal time = decimal.Parse(Console.ReadLine());

// TODO: Impementar lógica para perguntar se deseja utilizar minutos ou horas

// PROCESSAMENTO
decimal speed = distance / time;

// SAÍDA DE DADOS
Console.WriteLine("Aqui está sua estimativa " + name + ":");
Console.WriteLine($"Para percorrer {distance} km em {time} {(timeUnit == 1 ? "minutos" : "horas")}, você precisará de uma velocidade média de {speed}km por {(timeUnit == 1 ? "minuto" : "hora")}");

// TODO: implementar lógica para mostrar tambem a velocidade de m/km
