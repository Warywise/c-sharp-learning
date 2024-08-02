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
