namespace Método_Construtor;
class Program
{
   static void Main(string[] args)
    {
        //Produto p1 = new Produto(); (construtor 1)
        //Produto p1 = new Produto("SACI PERERE"); (construtor 2)
        
        //(construtor 3)
        Produto p1 = new Produto("ABC",10);

        

        p1.MostraDados();
    }
}
