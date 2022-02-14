// See https://aka.ms/new-console-template for more information
namespace Dio.Series
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    Listar();
                    break;
                    case "2":
                    Inserir();
                    break;
                    case "3":
                    Atualiza();
                    break;
                    case "4":
                    Excluir();
                    break;
                    case "5":
                    Visualizar();
                    break;
                    case "C":
                    LimparTela();
                    break;
                    case "X":
                    break;
                    default:
                    Console.WriteLine("Opção inválida");
                    break;
                }
            }
            
        }
        private static void Listar()
            {
                Console.WriteLine("Listando Series");
                foreach (var serie in repositorio.List())
                {
                    Console.WriteLine(serie);
                }
            }
        private static void Inserir()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine(((Genero)i).ToString());
            }
            Console.WriteLine("Digite o gero da serie");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserindo Serie");
            Console.WriteLine("Informe o titulo da serie");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe o genero da serie");
            string genero = Console.ReadLine();
            Console.WriteLine("Informe a descricao da serie");
            string descricao = Console.ReadLine();
            Console.WriteLine("Informe o ano de inicio da serie");
            int ano = int.Parse(Console.ReadLine());
            repositorio.Inserir(new Serie(repositorio.ProximoId(),
                                          (Genero)entradaGenero,
                                          titulo,
                                          descricao,
                                          ano));

        }
        private static void Atualiza()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine(((Genero)i).ToString());
            }

            Console.WriteLine("Digite o gero da serie");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o id da serie");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o titulo da serie");
            string titulo = Console.ReadLine();
            Console.WriteLine("Informe o genero da serie");
            string genero = Console.ReadLine();
            Console.WriteLine("Informe a descricao da serie");
            string descricao = Console.ReadLine();
            Console.WriteLine("Informe o ano de inicio da serie");
            int ano = int.Parse(Console.ReadLine());
            repositorio.Atualizar(id, new Serie(id,
                                            (Genero)entradaGenero,
                                            titulo,
                                            descricao,
                                            ano));
        }
        private static void Excluir()
        {
            Console.WriteLine("Informe o id da serie");
            int id = int.Parse(Console.ReadLine());
            repositorio.Excluir(id);
        }
        private static void Visualizar()
        {
            Console.WriteLine("Informe o id da serie");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(repositorio.RetornarPorIdd(id));
        }
        private static void LimparTela()
        {
            Console.Clear();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - listar");
            Console.WriteLine("2 - Inserir");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - EXcluir");
            Console.WriteLine("5 - Visualizar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");

            string opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("");
            return opcao;
    
        }

    }
}