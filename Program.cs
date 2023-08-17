using GeradorCurriculo.Models;

Console.WriteLine("CRIAR CURRICULO");

var pessoa = new Pessoa();

Console.WriteLine("Digite o nome da pessoa do currículo:");
var nome = Console.ReadLine();
Console.WriteLine("Digite a idade da pessoa:");
var idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o email da pessoa:");
var email = Console.ReadLine();

pessoa.Nome = nome;
pessoa.Idade = idade;
pessoa.Email = email;

var habilidade = new Habilidade();

Console.WriteLine("Digite uma habilidade para o Currículo:");
var nomeHabilidade = Console.ReadLine();
Console.WriteLine("Esta habilidade está em qual nível (de 0 - 10):");
var nivel = int.Parse(Console.ReadLine());

habilidade.Nome = nomeHabilidade;
habilidade.Nivel = nivel;

var formacao = new Formacao(2023, "segundo grau");
var experiencia = new Experiencia();
var curriculo = new Curriculo();

experiencia.Tempo = 2;
experiencia.Antecedentes = "Nenhum";
experiencia.Salario = 123232;

curriculo.Experiencia = experiencia;
curriculo.DadosPessoais = pessoa;
curriculo.Habilidade = habilidade;
curriculo.Formacao = formacao;


Console.WriteLine("CURRICULO CRIADO");

Console.WriteLine("DADOS PESSOAIS:");
Console.WriteLine("Nome: " + curriculo.DadosPessoais.Nome);
Console.WriteLine("Idade: " + curriculo.DadosPessoais.Idade);
Console.WriteLine("Email: " + curriculo.DadosPessoais.Email);

Console.WriteLine("HABILIDADE:");
Console.WriteLine("Nome: " + curriculo.Habilidade.Nome);
Console.WriteLine("Nível: " + curriculo.Habilidade.Nivel);

Console.WriteLine("HABILIDADE:");
Console.WriteLine("Tempo: " + curriculo.Experiencia.Tempo);
Console.WriteLine("Antecedentes: " + curriculo.Experiencia.Antecedentes);

Console.WriteLine("FORMACAO:");
Console.WriteLine(curriculo.Formacao);