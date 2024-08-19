// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(123);
Console.WriteLine(0.25F);
Console.WriteLine(2.625);
Console.WriteLine(12.398160M);
Console.WriteLine(12.398160F);
Console.WriteLine(true);
Console.WriteLine(false);

Console.WriteLine("123");
Console.WriteLine(123);

Console.WriteLine("true");
Console.WriteLine(true);

// inicializando com tipo explícito
string firstName;
firstName = "Bob";
// inicializando com tipo implícito (o tipo é inferido, sempre deve ser inicializado)
// var lastName; // erro
var lastName = "Smith";
Console.WriteLine(firstName + " " + lastName);

// usando escape de caracteres
string directory = "C:\\Users\\Public\\Documents";
string directoryExplain = "O documento se encontra no seguinte diretório:\n Directory:\t C:\\Users\\Public\\Documents";
Console.WriteLine(directory);
Console.WriteLine(directoryExplain);
Console.WriteLine();
// ou com verbatim string (cadeia de caracteres textual) - @string
directory = @"C:\Users\Public\Documents";
Console.WriteLine(directory);
// interpolação de cadeia de caracteres - $string
directoryExplain = $"O documento se encontra no seguinte diretório:\n Directory:\t \"{directory}\"";
Console.WriteLine(directoryExplain);
Console.WriteLine();
// combinando interpolação com verbatim string - $@string
int numberOfDocs = 3;
directoryExplain = $@"Os documentos se encontram no seguinte diretório:
Directory:           {directory}
Qnt:                 {numberOfDocs}";

Console.WriteLine(directoryExplain);

Console.WriteLine();

// Misturar tipos de dados
int age = 30;
decimal height = 1.75M;
string name = "Bob";
Console.WriteLine($"{name} tem {age} anos e {height}m de altura.");
// somar strings com números
Console.WriteLine("O resultado de 2 + 3 não é " + 2 + 3 + $", e nem {age}, mas sim " + (2 + 3));
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
// divisão de inteiros resulta em inteiro
int intQuotient = 7 / 5;
// divisão de decimais resulta em decimal
decimal decimalQuotient = 7M / 5;
// conversão de decimal para inteiro, mesmo com tipo de dado decimal o valor é convertido para inteiro
decimal convertedInt = (int)decimalQuotient;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
// resultará em 1, pois o tipo de dado é inteiro
Console.WriteLine("Int Quotient: " + intQuotient);
// resultará em 1.4, pois o tipo de dado é decimal
Console.WriteLine("Decimal Quotient: " + decimalQuotient);
Console.WriteLine("Converted Int: " + convertedInt);
// operador de módulo
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

Console.WriteLine();
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
value -= 5;        // value is now 5.
value++;           // value is now 6.
value--;           // value is now 5.
value *= 2;        // value is now 10.
value /= 2;        // value is now 5.
Console.WriteLine(value);
// dependendo da posição do operador, o valor pode ser incrementado antes ou depois da operação
// Ex: ++x faz o incremento antes de recuperar o valor, x++ faz o incremento depois de recuperar o valor
int x = 5;
int y = x++; // y = 5, x = 6
Console.WriteLine($"x = {x}, y = {y}");
x = 5;
y = ++x; // y = 6, x = 6
Console.WriteLine($"x = {x}, y = {y}");

Math.Max(5, 10);  // returns 10

// declarar matrizes (array)
// é necessário declarar o tipo de dado e o tamanho da matriz na inicialização
string[] names = new string[3];
names[0] = "Bob";
names[1] = "Joe";
// names[3] = "Ana"; // erro, pois o índice 3 não existe
Console.WriteLine($"Primeiro nome: {names[0]}");
Console.WriteLine($"Segundo nome: {names[1]}");
// Console.WriteLine($"Terceiro nome: {names[2]}"); // erro, pois o índice 2 não foi inicializado
Console.WriteLine(names);

Console.WriteLine();

// iteirando sobre uma matriz
int[] singleNumbers = [1, 2, 3, 4, 5];
foreach (int singleNumber in singleNumbers)
{
    Console.WriteLine(singleNumber);
}

string[] cars = new string[3];
cars[0] = "Volvo";
cars[2] = "BMW";
foreach (string car in cars)
{
    Console.WriteLine(car);
}

int[] inventory = [200, 450, 700, 175, 250];
int totalItems = 0;
foreach (int items in inventory)
{
    totalItems += items;
    Console.WriteLine($"Items: {items}, Total: {totalItems}");
}

Console.WriteLine($"We have {totalItems} items in inventory.");

string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith('B'))
    {
        Console.WriteLine($"Order ID: {orderID}");
    }
}

Console.WriteLine();
int[] array = [1, 2, 3, 4, 5];

PrintArray(array);
Clear(array);
PrintArray(array);

// um parâmetro array é uma referência, então a matriz original pode ser alterada (de forma limitada)
void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // é possível alterar o valor de um índice específico
        // não é possível alterar o tamanho da matriz
        // não é possível alterar a própria matriz diretamente
        array[i] = 0;
    }
}

// Coin flip - 0 = heads, 1 = tails (maxValue não é incluído)
Random coin = new();
int flip = coin.Next(0, 2);

if (flip == 0)
    Console.WriteLine("Heads" + flip);
else
    Console.WriteLine("Tails" + flip);

Console.WriteLine();
// FizzBuzz challenge
for (int count = 1; count <= 100; count++)
{
    bool fizz = count % 3 == 0;
    bool buzz = count % 5 == 0;

    if (fizz && buzz)
        Console.WriteLine($"{count} - FizzBuzz");
    else if (fizz)
        Console.WriteLine($"{count} - Fizz");
    else if (buzz)
        Console.WriteLine($"{count} - Buzz");
    else
        Console.WriteLine($"{count}");
}

// Arrays multidimensionais
int[,] matrix = new int[2, 3]; // 2 linhas, 3 colunas - { {0, 0, 0}, {0, 0, 0} }
matrix[0, 0] = 1; // a primeira posição do primeiro array é 1 - { {1, 0, 0}, {0, 0, 0} }
matrix[1, 2] = 5; // a terceira posição do segundo array é 5 - { {1, 0, 0}, {0, 0, 5} }

// jagged array (matriz multidimensional irregular)
int[][] jaggedArray = new int[3][]; // um array com 3 arrays de inteiros
jaggedArray[0] = new int[2]; // primeiro array com 2 inteiros - { {0, 0}, null, null }
jaggedArray[1] = new int[3]; // segundo array com 3 inteiros - { {0, 0}, {0, 0, 0}, null }
jaggedArray[2] = new int[4]; // terceiro array com 4 inteiros - { {0, 0}, {0, 0, 0}, {0, 0, 0, 0} }

// int [,,] threeD = new int[3, 2, 3]; // 3 arrays de 2 arrays de 3 inteiros
// { { {0, 0, 0}, {0, 0, 0} }, { {0, 0, 0}, {0, 0, 0} }, { {0, 0, 0}, {0, 0, 0} } }
