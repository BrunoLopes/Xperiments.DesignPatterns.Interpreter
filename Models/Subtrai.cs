namespace Xperiments.DesignPatterns.Interpreter.Models
{
    public class Subtrai : IExpressao
    {
        private IExpressao Esquerda;
        private IExpressao Direita;

        public Subtrai(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}