using HelloWorld.Teste;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        //Console.WriteLine("Olá, mundo!");
        //Console.WriteLine("Hello, World!");

        Carro meuCarro = new Carro();

        meuCarro.Ligar();

        meuCarro.Desligar();

        Biscoito meuBiscoito = new Biscoito();

        meuBiscoito.Temperatura();
    }
}