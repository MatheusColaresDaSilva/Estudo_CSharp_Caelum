using System;
using System.Windows.Forms;

namespace Banco
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
           /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/

            Conta contaVictor = new Conta();
            Cliente clienteVictor = new Cliente("victor");
            clienteVictor.Idade = 15;
            contaVictor.Titular = clienteVictor;
            contaVictor.Numero = 1;
            contaVictor.Deposita(100.0);

            Conta contaMauricio = new Conta();
            Cliente clienteMauricio = new Cliente("mauricio");
            clienteMauricio.Idade = 22;
            contaMauricio.Titular = clienteMauricio;
            contaMauricio.Numero = 2;
            contaMauricio.Deposita(2000.0);

            Console.WriteLine(contaVictor.Titular.Nome);
            Console.WriteLine(contaVictor.Numero.ToString());
            Console.WriteLine(contaVictor.Saldo.ToString());

            contaVictor.Deposita(50.50);
            Console.WriteLine(contaVictor.Saldo.ToString());

            if (contaVictor.Saca(1125.25))
            {
                Console.WriteLine("Saque realizando com sucesso");
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");            
            }

            Console.WriteLine(clienteVictor.EhMaiorDeIdade());
            Console.WriteLine(clienteMauricio.EhMaiorDeIdade());


        }
    }
}
