using System;

namespace TiposEVariavies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tipos de valor
            int numero1 = 10;
            int numero2 = 20;
            // var declara uma variável e define seu tipo dinamicamente
            var soma = numero1 + numero2;
            Console.WriteLine(numero1 +" + " + numero2 + " = " + soma);

            // Tipos de referência
            var message = new Message();
            var result = message;
            message.content = "Hello, Mendes!";
            // A mensagem deve ser "Hello, Mendes!" 
            Console.WriteLine("Mensagem: " + result.content);
        }
        class Message
        {
            public string content = "Hello, World!";
        }
    }
}
