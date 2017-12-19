namespace Xperiments.DesignPatterns.Interpreter.Models
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda * valorDireita;
        }
    }
}