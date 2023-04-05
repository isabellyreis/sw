namespace Conta_bancária;
class Program
{
   static void Main(string[] args)
    {
        Console.WriteLine("Exercicio Conta Bancária - ETEC MCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Giovanna Carvalho";
        //conta.numeroConta = 123;
        conta.limite = 500;
        //conta.saldo = 5000;
        conta.depositar(200);
        conta.sacar(50);

        //Console.WriteLine("Olá, " + conta.nomeCliente + ", seu saldo é de: " + conta.saldo);
        //Console.WriteLine("Seu limite é de: " + conta.limite);
        //Console.WriteLine("O número da sua conta é: " + conta.numeroConta);


        // Chamar o método ConsultaSaldo e receber em uma variável local chamada saldo o valor disponível em saldo desse cliente
        double saldo = conta.ConsultaSaldo();
        
        // Visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);
    } 
}
