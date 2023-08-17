namespace GeradorCurriculo.Models;

public class Formacao {

    public Formacao(int anoFormacao, string grauFormacao) {
        AnoFormacao = anoFormacao;
        GrauFormacao = grauFormacao;
    }

    public int AnoFormacao;
    public string Instituicao; 
    public string GrauFormacao; 


    public override string ToString() {
        return AnoFormacao + " " + GrauFormacao;
    }

}


