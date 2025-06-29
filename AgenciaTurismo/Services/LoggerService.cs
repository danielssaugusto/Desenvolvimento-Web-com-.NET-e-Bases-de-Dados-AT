using System;
using System.Collections.Generic;
using System.IO;

namespace AgenciaTurismo.Services
{
    public static class LoggerService
    {
        public static List<string> LogEmMemoria { get; } = new();

        public static void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[Console] {mensagem}");
        }

        public static void LogToFile(string mensagem)
        {
            string caminho = "log.txt";
            File.AppendAllText(caminho, $"[Arquivo] {mensagem}{Environment.NewLine}");
        }

        public static void LogToMemory(string mensagem)
        {
            LogEmMemoria.Add($"[Memória] {mensagem}");
        }
    }
}
