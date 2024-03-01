// See https://aka.ms/new-console-template for more information
using Checkpoint1.Models;

Console.WriteLine("Olá, bem vindo ao Zóológico FIAP");
Console.WriteLine("Escolha as opções a seguir para ver nosso zoológico");
Console.WriteLine("");
Console.WriteLine("1. Macaco");
Console.WriteLine("2. Cobra");
Console.WriteLine("3. Pássaro");
Console.WriteLine("4. Restaurante");


var num = Console.ReadLine();

switch (num)
{
    case "1":
        var macacoApresenta = new Macaco();
        var macaco = new Macaco("Lucas Shiaku", 20, true, "Uh Uh Ah Ah", 20);
        break;

    case "2":
        var cobraApresenta = new Cobra();
        var cobra = new Cobra("Leonardo", 2, false, "Tstststststst", "Neurotóxico");
        break;
    case "3":
        var passaroApresenta = new Passaro();
        var passaro = new Passaro("Kayky", 2, true, "Uaaa Uaaa Uaa", 200.0);
        break;
    case "4":
        var restauranteApresenta = new Restaurante();
        var restaurante = new Restaurante("Fiap dos Animais",3 , 9);
        break;
    default:
        Console.WriteLine("Esta opção não existe");
        break;

}



