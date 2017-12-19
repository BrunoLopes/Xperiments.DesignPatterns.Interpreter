namespace Xperiments.DesignPatterns.Interpreter.Models
{
    public class Divisao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}