using System;

class Car {
   public ICarCorpus Corpus { get; set; }
   public ICarEngine Engine { get; set; }

    public int mass {
        get {
            return Corpus.Weight + Engine.Weight;
        }
    }

    bool IsStart() {

        if ((mass * Engine.Power /1000) - 35 > 0)
        {
            return true;
        }
        else
            return false;
    }

    public void Start(){
        Console.WriteLine("Мощность двигателя:" + Engine.Power);
        if (IsStart() == true)
        {
            Engine.Start();
        }
        else {
            Console.WriteLine("Скдыщ-Пау; Машина взорвалась воставь двигло помощнее");
        }
    }
}

interface ICarCorpus {
    int Pasangeres { get; }
    int CorpusMass { get; }
    int Weight { get; }
}

class Corpus : ICarCorpus {
    public int Pasangeres { get; }
    public int CorpusMass { get; }

    public int Weight {
        get {
           return (Pasangeres * 80) + CorpusMass;
        }
    }
    public Corpus() {
        Pasangeres = 4;
        CorpusMass = 150;
    }


}


interface ICarEngine {
    void Start();
    void Stop();
    int Weight { get; }
    int Power { get; }
}

class ZhighoulEngine : ICarEngine {
   public int Weight { get; }
   public int Power { get; }



    public ZhighoulEngine() {
        Weight = 25;
        Power = 70;

    }

    public void Start() {
        Console.WriteLine("Тыр-Тыр-Тыр");
    }

    public void Stop() {
        Console.WriteLine("Тыыыыыр-Тыыыыыыр");
    }
}


class MEGAEngine : ICarEngine { 
    public int Weight { get; }
    public int Power { get; }

    public MEGAEngine() {
        Weight = 10;
        Power = 9010;
    }
    public void Start() {
        Console.WriteLine("ВЖЖЖЖЖЖУУУУУУУУУУУУУХ");
    }

    public void Stop() {
        Console.WriteLine("СКИДЫЩ");
    }
}



namespace Подготовка
{

    class Program
    {
        static void Main(string[] args)
        {
            Car care = new Car();
            care.Corpus = new Corpus();
            care.Engine = new ZhighoulEngine();
            care.Start();
            Console.WriteLine();
            Car car = new Car();
            car.Corpus = new Corpus();
            car.Engine = new MEGAEngine();
            car.Start();

        }






    }
}
