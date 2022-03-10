using System;
//TODO: Complete os espaços em branco com uma solução possível para o problema.
namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            var dias = int.Parse(Console.ReadLine());
            var anos = dias  ;
            dias = dias   ;
            var meses = dias;
            dias = dias;

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}