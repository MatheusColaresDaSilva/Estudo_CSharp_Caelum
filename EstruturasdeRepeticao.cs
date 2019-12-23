using System;

class EstruturadeRepeticao{

    static void Main(){

        Console.WriteLine();
        //Exer:2
        Console.WriteLine("Exercicio 2");
        int soma=0;
        for(int i = 0; i <=1000;i++){
            
            soma += i;
        }
        Console.WriteLine("Soma: " + soma);
        
        Console.WriteLine();
        //Exer:3,4
        Console.WriteLine("Exercicio 3 e 4");
        int somaNapMutiplos3 = 0;
        for(int i = 0; i <=100;i++){
            
            if(i%3==0){
                Console.Write(i+",");
            }
            else{
                somaNapMutiplos3 += i;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Soma dos não multiplo de 3: " + somaNapMutiplos3) ;

        Console.WriteLine();
        //Exer:5
        Console.WriteLine("Exercicio 5");
        int exer5=0;

        while(exer5<=30){
            if(exer5%3==0 || exer5%4==0){
                Console.Write(exer5+",");
            }
            exer5++;
        }

        Console.WriteLine();
        //Exer 6
        Console.WriteLine("Exercicio 6");
        int fatorial;
        int fatorialaux;
        for(int i = 1; i<=10; i++) {
            Console.Write("Fatorial de " + i + " é: " );
            fatorial = i;
            fatorialaux = fatorial-1;
            
            while(fatorialaux!=0){
                fatorial *= (fatorialaux);
                fatorialaux--;
            }
            
            Console.WriteLine(fatorial);
        }

        Console.WriteLine();
        //Exer 7
        Console.WriteLine("Exercicio 7");
        int primeiro = 0;
        int segundo = 1;
        int auxiliar;
        Console.Write("Fibonacci: " + primeiro + "," + segundo + ",");

        while(primeiro<100){
            
            auxiliar = primeiro + segundo;
            primeiro = segundo;
            segundo = auxiliar;
            Console.Write(auxiliar + ",");
           
        }

        Console.WriteLine();
        //Exer 8
        Console.WriteLine("Exercicio 8");
        for(int i=1 ; i <= 10; i++){
            for(int j = 1; j <=i; j++){
                Console.Write(i*j +" ");
            }
             Console.WriteLine();
        }
        
    }
}