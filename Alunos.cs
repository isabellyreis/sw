namespace ExercicioAlunos;
class Alunos
{
   public string nome="";
   public double nota1, nota2;

   //média
   public double obterMedia(){
    double media = (nota1+nota2)/2;
    return media;
   }

   //situação
   public string obterSituacao(double media){
    string situacao="";
    if(media>=6){
        situacao="Aprovado(a) ";
    }else{
        situacao="Reprovado(a) ";
    }
    return situacao;
   }

   //mensagem
   public void mensagem(){
    double mediaCalculada = obterMedia();
    string resultadoSituacao = obterSituacao(mediaCalculada);
    Console.WriteLine(nome+" está " +resultadoSituacao+" com média: "+mediaCalculada);
   }
}