using Atividade1.Classes;

Console.Clear();

Console.WriteLine(@$"
===================================================================
|              Bem Vindo ao Sistema de Cadastro de                |
|                  Pessoas Físicas e Jurídicas                    |
===================================================================
");

BarraCarregamento("Carregando ", 200);

List<PessoaFisica>listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    
Console.Clear();

Console.WriteLine(@$"
===================================================================
|                 Escolha uma das opções abaixo                   |
|-----------------------------------------------------------------|
|                      1 - Pessoa Física                          |
|                      2 - Pessoa Jurídica                        |
|                                                                 |
|                      0 - Sair                                   |
===================================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        PessoaFisica metodoPf = new PessoaFisica();

        string? opcaoPf;


        do
        {
            Console.Clear();
            Console.WriteLine(@$"
===================================================================
|                 Escolha uma das opções abaixo                   |
|-----------------------------------------------------------------|
|                      1 - Cadastrar Pessoa Física                |
|                      2 - Mostrar Pessoas Jurídicas              |
|                                                                 |
|                      0 - Voltar ao menu anterior                |
===================================================================
                                
                    ");
            opcaoPf = Console.ReadLine ();
            switch (opcaoPf)
            {
                case "1":
                        Console.Clear();
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine ();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AAAA");
                        string dataNasc = Console.ReadLine();

                        dataValida = metodoPf.ValidarDataNascimento(dataNasc);
                        if (dataValida)
                        {
                            novaPf.dataNascimento = dataNasc;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Data digitada inválida, por favor digite uma data válida");
                            Console.ResetColor();
                        }

                        } while (dataValida == false);

                        Console.WriteLine($"Digite o número do cpf");
                        novaPf.cpf = Console.ReadLine ();

                        Console.WriteLine($"Digite o rendimento");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte enter para vazio)");
                        novoEnd.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial =true;
                        }
                        else
                        {
                            novoEnd.endComercial = false;
                        }
                        novaPf.endereco = novoEnd;

                        listaPf.Add(novaPf);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                        Console.Clear();
                    break;

                case "2":
                    Console.Clear();
                    if(listaPf.Count > 0)
                    {
                       foreach (PessoaFisica cadaPessoa in listaPf)
                       {
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Data de Nascimento: {cadaPessoa.dataNascimento}
                                    Cpf: {cadaPessoa.cpf}
                                    Rendimento: {cadaPessoa.rendimento}
                                    Logradouro: {cadaPessoa.endereco.logradouro}
                                    Numero: {cadaPessoa.endereco.numero}
                                    Complemento: {cadaPessoa.endereco.complemento}
                                    Endereço Comercial? {((bool)cadaPessoa.endereco.endComercial? "Sim": "Não")}
                                    Maior de idade? {(metodoPf.ValidarDataNascimento(cadaPessoa.dataNascimento) ? "Sim": "Não")}
                                    Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                    ");

                                    Console.WriteLine($"Aperte 'Enter' para continuar...");
                                    Console.ReadLine();
                       }

                    }
                    else
                    {
                         Console.WriteLine($"Lista vazia!!");
                        Thread.Sleep(3000);
                    }

                    break;

                case "0":
                // a opção 0 retorna ao menu anterior, não vou inserir nenhuma mensagem

                    break;
                default:;
                    break;
            }
            
            
        } while (opcaoPf !="0");

       
            
        break;


    case "2":
        PessoaJuridica metodoPj = new PessoaJuridica();
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Nome PJ";
        novaPj.cnpj = "00.000.000/0001-00";
        novaPj.razaoSocial = "Razao Social PJ";
        novaPj.rendimento = 5000;

        novoEndPj.logradouro = "Rua Goitacazez";
        novoEndPj.numero = 300;
        novoEndPj.complemento = "Esquina com a Niteroi";
        novoEndPj.endComercial = true;

        novaPj.endereco = novoEndPj;

        Console.Clear();

        Console.WriteLine(@$"
            Nome: {novaPj.nome}
            CNPJ: {novaPj.cnpj}
            Razao Social: {novaPj.razaoSocial}
            Rendimento: {(novaPj.rendimento).ToString("C")}
            Logradouro: {novaPj.endereco.logradouro}
            Numero: {novaPj.endereco.numero}
            Complemento: {novaPj.endereco.complemento}
            Endereço Comercial? {((bool)novaPj.endereco.endComercial? "Sim":"Não")}
            CNPJ é valido? {(metodoPj.ValidarCnpj(novaPj.cnpj)? "Sim": "Não")}
            Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");
            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
        break;

        
    case "0":
        BarraCarregamento("Finalizando ", 200);
        break;
    default:
        Console.Clear();
        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
        Thread.Sleep(1000);
        break;
}
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo){
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write($"{texto}");

        for (var contador = 0; contador < 25; contador ++)
        {
            Console.Write(". ");
            Thread.Sleep(tempo);
        }

        Console.ResetColor();
}






















/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();
PessoaFisica metodoPf = new PessoaFisica();

novaPf.nome = "Lozano";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678900";
novaPf.rendimento = 1500;

novoEnd.logradouro = "Rua Niteroi";
novoEnd.numero = 180;
novoEnd.complemento = "Escola Senai de Informática";
novoEnd.endComercial = "true";

novaPf.endereco = novoEnd;
*/

/*
Console.WriteLine($"Nome: {novaPf.nome}");
Console.WriteLine($"Data de Nasciemnto: {novaPf.dataNascimento}");
Console.WriteLine($"Cpf: {novaPf.cpf}");
Console.WriteLine($"Rendimento: {novaPf.rendimento}");
Console.WriteLine($"Logradouro: {novaPf.endereco.logradouro}");
Console.WriteLine($"Numero: {novaPf.endereco.numero}");
Console.WriteLine($"Complemento: {novaPf.endereco.complemento}");
Console.WriteLine($"Endereco Comercial?: {novaPf.endereco.endComercial}");
Console.WriteLine($"Maior de Idade? {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}");
*/

/*
PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();


novaPj.nome = "Nome Pj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "Razao Social PJ";
novaPj.rendimento = 5000;

novoEndPj.logradouro = "Rua Goitacazez";
novoEndPj.numero = 300;
novoEndPj.complemento = "Esquina com Niteroi";
novoEndPj.endComercial = "true";

novaPj.endereco = novoEndPj;



Console.WriteLine(@$"
Nome: {novaPj.nome}
CNPJ: {novaPj.cnpj}
RazaoSocial: {novaPj.razaoSocial}
Rendimento: {novaPj.rendimento}
Logradouro: {novaPj.endereco.logradouro}
Numero: {novaPj.endereco.numero}
Complemento: {novaPj.endereco.complemento}
Endereço Comercial? {novaPj.endereco.endComercial}
CNPJ é valido?: {metodoPj.ValidarCnpj(novaPj.cnpj)}
");

*/

//Console.WriteLine($"{metodoPj.ValidarCnpj("00.000.000/0001-00")}");
//Console.WriteLine($"{metodoPj.ValidarCnpj("00000000000100")}");





/*
Console.WriteLine(@$"
Nome: {novaPf.nome}
Data de Nascimento: {novaPf.dataNascimento}
Cpf: {novaPf.cpf}
Rendimento: {novaPf.rendimento}
Logradouro: {novaPf.endereco.logradouro}
Numero: {novaPf.endereco.numero}
Complemento: {novaPf.endereco.complemento}
Endereço Comercial? {novaPf.endereco.endComercial}
Maior idade?: {metodoPf.validarDataNascimento(novaPf.dataNascimento)}
");

*/
// Console.WriteLine(novaPf.validarDataNascimento(new DateTime(2000,01,01)));

//Console.WriteLine(novaPf.validarDataNascimento("2010,01,01"));

//Console.WriteLine(novaPf.validarDataNascimento("01-01-2010"));


/*
novaPf.nome = "Lozano";

Console.WriteLine(novaPf.nome);

//Concatenação
Console.WriteLine("Nome: " + novaPf.nome);

//Interpolação
Console.WriteLine($"Nome: {novaPf.nome}");


cwl + tab 9 (cria o console write line (atalho é do snippets))
*/