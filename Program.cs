int contador = 0;
Console.Write("Quantas vezes?  ");
int qtdvezes = Convert.ToInt32(Console.ReadLine());

while (contador < qtdvezes)

{

    contador = contador + 1;
    Console.WriteLine($"{contador}x Santos maior time.");

}