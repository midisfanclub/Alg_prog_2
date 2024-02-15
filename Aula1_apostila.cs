using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Media(string[] args) {
    
    Console.WriteLine("Quantos alunos há na turma?\n");
    int tamanho = Convert.ToInt32(Console.ReadLine());
    double[] notas = new double [tamanho];

    for (int i=0; i < notas.Length; i++) 
    {
        Console.WriteLine("digite a nota do aluno " + (i + 1) + ":");
        notas[i] = Convert.ToDouble(Console.ReadLine());
    }

    
    double soma = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("Nota do aluno " + (i + 1) + ":" + notas[i]);
        soma += notas[i];
    }

    double media = soma/notas.Length;
    Console.WriteLine("A média das notas da turmas é: " + media);

    }
}