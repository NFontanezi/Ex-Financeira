// See https://aka.ms/new-console-template for more information

using Financeira;


int opcao;
bool opcaoValida = false;
do
{
    do
    {
    Console.Clear();
    Console.WriteLine("Cadastrar");
    Console.WriteLine("1-Pessoa Fisica\n2-Pessoa Juridica\n3-Listar Contratos\n4-Sair");

    

        opcaoValida = int.TryParse(Console.ReadLine(), out opcao) && opcao == 1 || opcao == 2 || opcao == 3 || opcao==4;
        if (opcaoValida)
        {
            opcaoValida = true;
            break;

        }
        Console.WriteLine("Opçao Invalido");
        Console.ReadKey();
    } while (!opcaoValida);

    if (opcao == 1) //SEM CONSTRUTOR DEFINIDO
    {
        ContratoPessoaFisica clientePF = new();
        clientePF.Contratante = Cadastro.ObterContratante();
        clientePF.CPF = Cadastro.ObterCPF();
        clientePF.Valor = Cadastro.ObterValor();
        clientePF.Prazo = Cadastro.ObterPrazo();
        clientePF.DataNasc = Cadastro.ObterDataNasc();
        clientePF.SalvarListaPF(clientePF);

    }
    if (opcao==2) //COM CONSTRUTOR DEFINIDO
    { 
        var pjcontratante = Cadastro.ObterContratante();
        var pjCNPJ = Cadastro.ObterCNPJ();
        var pjvalor = Cadastro.ObterValor();
        var pjprazo = Cadastro.ObterPrazo();
        var pjinscricao = Cadastro.ObterInscricao();

        ContratoPessoaJuridica clientePJ = new(pjCNPJ, pjinscricao, pjcontratante, pjvalor, pjprazo);
        clientePJ.SalvarListaPJ(clientePJ);


    }
    if(opcao==3)
    {
        Console.Clear();
        ContratoPessoaFisica.ExibirListaPF();
        ContratoPessoaJuridica.ExibirListaPJ();
        Console.ReadKey();
        
    }


} while (opcao != 4);