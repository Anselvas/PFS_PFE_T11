
using Atividade1.Classes;

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