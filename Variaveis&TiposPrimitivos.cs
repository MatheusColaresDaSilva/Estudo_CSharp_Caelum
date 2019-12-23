using System;
using System.Linq;

class Exercicio{

    public static int Media(int[] idades){
        
        int sumIdade = 0;
        int countIdade = 0;
        int media;

        foreach(int idade in idades){
            sumIdade = sumIdade + idade;
            countIdade++;
        }

        media = sumIdade/countIdade;
        return media;
    }

    static void Main(){
        
        int idadeDani = 28;
        int idadePaulo = 29;
        int idadeJesus = 33;

        int[] arrayIdade = {idadeDani,idadePaulo,idadeJesus};

        int mediaIdade = Media(arrayIdade);
        Console.WriteLine("Median by Function " + mediaIdade);
        mediaIdade = (int) Queryable.Average(arrayIdade.AsQueryable());
        Console.WriteLine("Median by Linq " + mediaIdade);

        /* ERRO int pi = 3.14; */

        double pi = 3.14;
        int piQuebrado = (int)pi;
        Console.WriteLine("piQuebrado = " + piQuebrado);
    }
}