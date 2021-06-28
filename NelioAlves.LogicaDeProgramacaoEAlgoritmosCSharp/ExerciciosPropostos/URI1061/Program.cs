using System;

namespace URI1061
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            string[] diaInicioEntry = Console.ReadLine().Split(' ');
            string[] horarioInicioEntry = Console.ReadLine().Split(' ');
            string[] diaFimEntry = Console.ReadLine().Split(' ');
            string[] horarioFimEntry = Console.ReadLine().Split(' ');
            // Definição dos dados
            int diaInicio = int.Parse(diaInicioEntry[1]);
            int horaInicio = int.Parse(horarioInicioEntry[0]);
            int minutosInicio = int.Parse(horarioInicioEntry[2]);
            int segundosInicio = int.Parse(horarioInicioEntry[4]);

            int diaFim = int.Parse(diaFimEntry[1]);
            int horaFim = int.Parse(horarioFimEntry[0]);
            int minutosFim = int.Parse(horarioFimEntry[2]);
            int segundosFim = int.Parse(horarioFimEntry[4]);
            // Cálculos Parâmetros
            int diasTotal = diaFim - diaInicio - 1;
            int diaInicioTotal = (diaInicio * 86400) + (horaInicio * 3600) + (minutosInicio * 60) + segundosInicio;
            int diaFimTotal = (diaFim * 86400) + (horaFim * 3600) + (minutosFim * 60) + segundosFim;
            int totalDuracaoSeg = diaFimTotal - diaInicioTotal;
            // Cálculos
            int totalDia = totalDuracaoSeg / 86400;
            int restoDia = totalDuracaoSeg % 86400;

            int totalHoras = restoDia / 3600;
            int restoHoras = restoDia % 3600;

            int totalMinutos = restoHoras / 60;
            int restoMinutos = restoHoras % 60;

            int totalSegundos = restoMinutos;
            // Saída de dados
            Console.WriteLine(totalDia + " dia(s)");
            Console.WriteLine(totalHoras + " hora(s)");
            Console.WriteLine(totalMinutos + " minuto(s)");
            Console.WriteLine(totalSegundos + " segundo(s)");
        }
    }
}
