﻿using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquico msg = new LerArquico();
            var mens = msg.LerArquivo();

            Console.WriteLine($"Hello World! o Cryp é  e o Descryp é{mens} ");
        }
    }
}
