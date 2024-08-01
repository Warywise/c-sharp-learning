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
