using System;

namespace Dio.Serie
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsurio = obterOpcaoUsuario();
            while (opcaoUsurio.ToUpper () != X)
           { 
                switch (opcaoUsurio)
                {
                     case "1":
                     ListarSerie();
                     break;
                       case "2":
                     InserirSerie();
                     break;
                       case "3":
                    AtualizarSerie();
                     break;
                       case "4":
                     ExcluirSerie();
                     break;
                       case "5":
                    VisualizarSerie();
                     break;
                       case "C":
                     Console,clear();
                     break;
                      default:
                       throw new ArgumentOutOfRangeException;
                   
                }
                opcaoUsurio = obterOpcaoUsuario();
           }
           Console.WriteLine("Obrigado por Utilizar nosso serviços");
           Console.Readline();
        }

        private static void ListarSerie()
        {
             console.WriteLine (" ListarSerie");

             var lista = repositorio.Lista();

             if(lista.count == 0)
             {
                 console,WriteLine(" nenhuma serie cadastrada !!!");
                 return;
             }

             foreach(var serie in lista)
             {
                 console.WriteLine(' #ID {0}: . {1}' , serie.retornaId(), serie.retornaTitulo() );
             }
        }
            

         private static void InserirSerie()
         {
             console.WriteLine(" inserir nova série");

             //https://docs.microsoft

             foreach (init i in Enum.get.Values(typeof(Genero)))
             {
                 console.WriteLine(" {0}.{1} ", i, Enum.GetName(typeof(Genero)), i) );
             }
             console.write (" Digite o gênero entre as opções acima");
             int entradagenero = int.parse(console.Readline());

             Console.write(" Digite o Titulo da Série: ");
             string entradaTitulo = console.Readline()

             Console.write(" Digite Ano de Inicio  da Série: ");
             string entradaAno = int.Parse( console.Readline());

             Console.write(" Digite Descrição da Série: ");
             string entradaDescriçao = console.Readline();

             Serie novaSerie = new Serie (id: repositorio.ProximoId(), genero: (Genero))entradagenero,titulo:entradaTitulo.
                                         ano:entradaAno,
                                         descricao: entradaDescriçao);

             repositorio.Insere(novaSerie);                            


         }   
        


        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine('Dio Série a seu dispor !!!');
            Console.WriteLine('Informe a Opção desejada');

            Console.WriteLine( " 1- Listar série ");
            Console.WriteLine(" 2 - inserir nova s-erie" );
            Console.WriteLine(" 3 - Atualiza série");
            Console.WriteLine(" 4 - Excluir série");
            Console.WriteLine(" 5 - Visualizar série");
            Console.WriteLine(" C - limpar série");
            Console.WriteLine(" X - sair");
            Console.WriteLine();

            string obterOpcaoUsuario = Console.Readline().ToUpper();
            Console.WriteLine();
            return opcaoUsurio;
        }
    }
}
