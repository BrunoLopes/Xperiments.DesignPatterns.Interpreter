using System;

namespace Xperiments.DesignPatterns.Interpreter.Models
{
    public class RaizQuadrada : IExpressao 
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e) 
        {
            this.expressao = e;
        }

        public int Avalia() 
        {
            return (int) Math.Sqrt(expressao.Avalia());
        }
    }
}