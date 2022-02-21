namespace ClaraAceitaPix
{
    public interface IOperacoesBD
    {
        void Inserir();
        void Alterar();
        void Deletar();
        void Pesquisar();
    }

    public abstract class Cadastros
        : IOperacoesBD
    {
        protected object Conexao { get; set; }

        protected Cadastros(object conexao)
        {
            Conexao = conexao; 
        }
        
        public void Alterar()
        {
            Console.WriteLine("Alterarado");
        }

        public void Deletar()
        {
            Console.WriteLine("Deletado");
        }

        public void Inserir()
        {
            Console.WriteLine("Inserido");
        }

        public void Pesquisar()
        {
            Console.WriteLine("Pesquisado");
        }
    }

    public class Clientes : Cadastros
    {
        public Clientes(object conexao)
            : base(conexao)
        {

        }

        public void Deletar(int id)
        {
            base.Deletar();
            Console.WriteLine($"Clientes: Deletado {id}");
        }
    }

    public class Pedidos : Cadastros
    {
        public Pedidos(object conexao)
            : base(conexao)
        {

        }

        public void Deletar(int id)
        {
            base.Deletar();
            Console.WriteLine($"Pedidos: Deletado {id}");
        }

        public void Inserir(object pedido)
        {
            Console.WriteLine($"Pedidos: Inserido {pedido}");
        }
    }
}