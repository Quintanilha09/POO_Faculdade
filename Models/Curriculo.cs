namespace GeradorCurriculo.Models;

public class Curriculo {
    public Pessoa DadosPessoais { get; set; } = new Pessoa();
    public Habilidade Habilidade { get; set; } = new Habilidade();
    public Experiencia Experiencia;
    public Formacao Formacao;
    
}