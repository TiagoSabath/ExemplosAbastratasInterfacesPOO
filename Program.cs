using ExemplosAbasstratasInterfacesPOO.Interfaces;
using ExemplosAbasstratasInterfacesPOO.Models;

Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();



ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));
Console.WriteLine(calc.Dividir(3,9));
Console.WriteLine(calc.Somar(3,9));
Console.WriteLine(calc.Subtrair(3,9));
