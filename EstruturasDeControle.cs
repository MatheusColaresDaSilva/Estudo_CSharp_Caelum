using System;

class EstruturasDeControle{

    static void Main(){
        int idade = 12;
        bool brasileira = false;

        if (idade >= 16 || brasileira)
        {
            if(brasileira){
              Console.WriteLine("Você pode Votar no BR");
            }
            else {
              Console.WriteLine("Você não é BR");
            }
        }
        else
        {
           Console.WriteLine("Você é de menor");
        }
        
    }
}