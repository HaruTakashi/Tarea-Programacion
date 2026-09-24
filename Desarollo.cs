using System;

class Program
{
    public static int bolsa;
    static void Main(string[] args)
    {
        Cofre MiCofre = new Cofre();
        MiCofre.crearCofre();
        MiCofre.Revisar();
        MiCofre.Abrir();
    }
}


class Cofre{
    public int tipo;
    public int oro;
    public bool abierto;
    public string tipoStr = "Cofre";
    Random creadorAleatorio = new Random();

    public void crearCofre(){
        tipo = creadorAleatorio.Next(1, 4);
        switch (tipo)
        {
            case 1:
            tipoStr = "Cofre de Madera";
            oro = creadorAleatorio.Next(25, 76);
            break;
            case 2:
            tipoStr = "Cofre de Plata";
            oro = creadorAleatorio.Next(50, 151);
            break;
            case 3:
            tipoStr = "Cofre de Oro";
            oro = creadorAleatorio.Next(100, 301);
            break;
        }
        int Prob = creadorAleatorio.Next(2);
        if(Prob == 0){
            abierto = true;
        }else{
            abierto=false;
        }
    }

    public void Abrir(){
        if(abierto){
            Program.bolsa = Program.bolsa+oro;
            Console.WriteLine($"Encontraste {oro}g, por lo que tu bolsa ahora tiene {Program.bolsa}g");
        }else{
            Console.WriteLine("El cofre esta cerrado y no tienes la llave.");
        }
    }

    public void Revisar(){
        Console.WriteLine($"{tipoStr}");
        if(abierto){
            Console.WriteLine("Abierto");
        }else{
            Console.WriteLine("Cerrado");
        }
    }
}