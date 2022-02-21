namespace ClaraAceitaPix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Funcoes
            // soma de matriz
            var funcoes = new Funcoes();
            var soma = funcoes.Soma(new int[] {1, 2, 3, 4});
            var maior = funcoes.Maior(1, 2, 3, 100);
            
            Console.WriteLine($"soma: ${soma} / maior: ${maior}");

            // Cadastros
            var conexao = new object();
            var cadastros = new Clientes(conexao);
            cadastros.Deletar(1);

            var pedidos = new Pedidos(conexao);
            pedidos.Deletar(1);
            pedidos.Inserir(new { valor = 10.0, quantidade = 1, descricao = "Camiseta" });

            Console.ReadLine();
        }
    }
}