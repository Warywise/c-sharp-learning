// ENTRADA DE DADOS
// Método ReadLine() é utilizado para ler a entrada do usuário
Console.WriteLine("Boas vindas ao programa 'Calcula Velocidade'!");
Console.WriteLine("Primeiramente, qual o seu nome?");
// Para strings não é necessário converter o tipo
string? name = Console.ReadLine();
Console.WriteLine("\nOlá, " + name + "! Vamos calcular a velocidade média necessária para percorrer uma distância em um determinado tempo. Para isso, precisaremos de alguns dados.");

Console.WriteLine("Para continuar, digite: OK");
string? userResponse= Console.ReadLine();

if (userResponse != null && userResponse.Trim().ToUpper() != "OK")
{
  Console.WriteLine("Encerrando o programa...");
  return;
}

bool userInputIsValid;

Console.WriteLine("\nInforme a distância a ser percorrida em quilômetros: ");
decimal distance;
userInputIsValid = decimal.TryParse(Console.ReadLine(), out distance);

VerifyUserInputIsValid();

Thread.Sleep(1000);

Console.WriteLine("\nEscolha a unidade de tempo para o cálculo da velocidade média:");
Console.WriteLine("Digite \" 1 \", para Minutos");
Console.WriteLine("Digite \" 2 \", para Horas");
int timeUnit;
int triesNumber = 0;

do {
    _ = int.TryParse(Console.ReadLine(), out timeUnit);

  if (timeUnit != 1 && timeUnit != 2)
  {
    if (triesNumber > 2) {
      Console.WriteLine("Número de tentativas excedido. Encerrando o programa...");
      return;
    }
    triesNumber++;
    Console.WriteLine("Opção inválida. Por favor, digite \" 1 \" para Minutos ou \" 2 \" para Horas");
  }
} while (timeUnit != 1 && timeUnit != 2);

Console.WriteLine("\nInforme o tempo disponível para percorrer essa distância: ");
// "time" pode ser declarado na mesma linha que a verificação do valor
userInputIsValid = decimal.TryParse(Console.ReadLine(), out decimal time);

VerifyUserInputIsValid();

// TODO: Impementar lógica para utilizar minutos ou horas

// PROCESSAMENTO
decimal speed = distance / time;
// spped com no máximo 3 casas decimais
speed = Math.Round(speed, 3);

// SAÍDA DE DADOS
Console.WriteLine("\nAqui está sua estimativa " + name + ":");
Console.WriteLine($"Para percorrer {distance} km em {time} {(timeUnit == 1 ? "minutos" : "horas")}, você precisará de uma velocidade média de {speed}km por {(timeUnit == 1 ? "minuto" : "hora")}. \nPara isso será necessário percorrer cada quilômetro em aproximadamente {time / distance} {(timeUnit == 1 ? "minutos" : "horas")}.");

// encerra a aplicação se o input do usuário for inválido
void VerifyUserInputIsValid()
{
  if (!userInputIsValid)
  {
    Console.WriteLine("Valor inválido. Encerrando o programa...");
    // TODO: existe uma forma menos abrupta de fechar a aplicação?
    Environment.Exit(0);
  }
}
