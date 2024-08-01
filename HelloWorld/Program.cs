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
