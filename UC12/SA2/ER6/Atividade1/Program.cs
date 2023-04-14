using Atividade1.Classes;

Console.WriteLine(@$"
===================================================================
|              Bem Vindo ao Sistema de Cadastro de                |
|                  Pessoas Físicas e Jurídicas                    |
===================================================================
");

BarraCarregamento("Carregando ", 200);

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
        PessoaFisica novaPf = new PessoaFisica();
        Endereco novoEnd = new Endereco();
        PessoaFisica metodoPf = new PessoaFisica();

        novaPf.nome = "Lozano";
        novaPf.dataNascimento = "18/02/1984";
        novaPf.cpf = "12345678900";
        novaPf.rendimento = 10000;

        novoEnd.logradouro = "Rua Niteroi";
        novoEnd.numero = 180;
        novoEnd.complemento = "Escola Senai de Informática";
        novoEnd.endComercial = true;

        novaPf.endereco = novoEnd;

        Console.Clear();

        Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Data de Nascimento: {novaPf.dataNascimento}
            Cpf: {novaPf.cpf}
            Rendimento: {novaPf.rendimento}
            Logradouro: {novaPf.endereco.logradouro}
            Numero: {novaPf.endereco.numero}
            Complemento: {novaPf.endereco.complemento}
            Endereço Comercial? {((bool)novaPf.endereco.endComercial? "Sim": "Não")}
            Maior de idade? {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim": "Não")}
            Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar...");
            Console.ReadLine();
            
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