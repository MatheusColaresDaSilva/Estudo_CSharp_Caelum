using System;

class Exercico_Bhaskara{

    static void Main(){
        
        int a,b,c;
        double delta,a1,a2;

        Console.WriteLine("Calcule Bhaskara:");
        Console.WriteLine("Digite o valor de A:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de B:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de C:");
        c = int.Parse(Console.ReadLine());
        
        delta = b*b - 4*a*c;
        a1 = ( b*-1 + Math.Sqrt(delta)) / (2 * a);
        a2 = ( b*-1 - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine("Delta: "+delta+" A1: "+ a1 + " A2: "+ a2);

    }
}