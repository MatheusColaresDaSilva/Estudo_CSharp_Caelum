using System;

class EstruturasdeControle2{

    static void Main(){
        Console.WriteLine("Digite o valor da Nota Fiscal:");
        double valorNotaFiscal = double.Parse(Console.ReadLine());
        
        if(valorNotaFiscal<999) valorNotaFiscal=valorNotaFiscal*0.02;
        else if(valorNotaFiscal<2999) valorNotaFiscal=valorNotaFiscal*0.025;
        else if(valorNotaFiscal<6999) valorNotaFiscal=valorNotaFiscal*0.028;
        else valorNotaFiscal=valorNotaFiscal*0.03;

        Console.WriteLine("O valor do juros é: " + valorNotaFiscal);

        //Desafio
        int valor = 15;
        string mensagem = "";
        /*if(valor > 10)
        {
        mensagem = "Maior que dez";
        }
        else
        {
        mensagem = "Menor que dez";
        }
        Console.WriteLine(mensagem);*/

        Console.WriteLine(mensagem = valor > 10 ? "Maior que dez": "Menor que dez");
      

    }
}