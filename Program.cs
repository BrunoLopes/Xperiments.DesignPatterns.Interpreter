using System;
using System.Linq.Expressions;
using Xperiments.DesignPatterns.Interpreter.Models;

namespace Xperiments.DesignPatterns.Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtrai(new Numero(17), new Numero(4));
            IExpressao resultSoma = new Soma(esquerda, direita);
            IExpressao resultMultiplicacao = new Multiplicacao(esquerda, direita);
            IExpressao resultDivisao = new Divisao(esquerda, direita);

            Console.WriteLine( resultSoma.Avalia() );
            Console.WriteLine( resultMultiplicacao.Avalia() );

            // Avaliador de Expressões da própria linguagem C# 
            // Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(29));
            // Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            // Console.WriteLine(funcao.Invoke());
        }
    }
}
