// ENTRADA DE DADOS
// Método ReadLine() é utilizado para ler a entrada do usuário
Console.WriteLine("Boas vindas ao programa 'Calcula Velocidade'!");
Console.WriteLine("Primeiramente, qual o seu nome?");
// Para strings não é necessário converter o tipo
string name = Console.ReadLine();
Console.WriteLine("Olá, " + name + "! Vamos calcular a velocidade média necessária para percorrer uma distância em um determinado tempo. Para isso, precisaremos de alguns dados.");

// TODO: Implementar lógica para usuário aceitar ou não continuar

Console.WriteLine("Informe a distância a ser percorrida em quilômetros: ");
decimal distance = decimal.Parse(Console.ReadLine());

// TODO: Verificar possibilidade de aguardar um tempo em segundos até próxima execução

Console.WriteLine("Informe o tempo disponível para percorrer essa distância em horas: ");
decimal time = decimal.Parse(Console.ReadLine());

// TODO: Impementar lógica para perguntar se deseja utilizar minutos ou horas

// PROCESSAMENTO
decimal speed = distance / time;

// SAÍDA DE DADOS
Console.WriteLine("Aqui está sua estimativa " + name + ":");
Console.WriteLine("Para percorrer " + distance.ToString("N2") + " quilômetros em " + time.ToString("N2") + " horas, " + "você precisará de uma velocidade média de " + speed.ToString("N2") + " km/h.");
