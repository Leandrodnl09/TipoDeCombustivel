// Exercício do site URI "Tipo de combustivel"
// Este programa o usuario ira digitar indeterminado numeros inteiros que corresponde ao tipo de combustivel
// Caso nõa corresponda o numero não e somado. No final mostar o total de cada combontivel, começando com a mensagem "muito Obrigado"

int X = int.Parse(Console.ReadLine());
int Alcool, Gasolina, Diesel;

Alcool = 0;
Gasolina = 0;
Diesel = 0;

while (X != 4)
{
    if (X == 1)
    {
        Alcool = Alcool + 1;
    }
    if (X == 2)
    {
        Gasolina = Gasolina + 1;
    }
    if (X == 3)
    {
        Diesel = Diesel + 1;
    }
X = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: " + Alcool);
Console.WriteLine("Gasolina: " + Gasolina);
Console.WriteLine("Diesel: " + Diesel);