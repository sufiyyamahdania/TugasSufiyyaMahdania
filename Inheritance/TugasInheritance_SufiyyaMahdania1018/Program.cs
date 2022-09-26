//Nama  : Sufiyya Mahdania
//NIM   : 212410101018
using ProcessorClass;
using System.Diagnostics;

//Membuat class processor dan prosessor classnya
class Processor
{
    public string merk;
    public string tipe;
}

namespace ProcessorClass
{
    class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }

    class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }

    class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }

    class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }

    class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "RAYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}


//membuat class laptop beserta methodnya
class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}

class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}


class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}


class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}

class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}

//membuat class vga
class Vga
{
    public string merk;

}

class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}

class AMD : Vga
{
    public AMD()
    {
        merk = "AMD";
    }
}



//class program beserta menjawab soal
class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        Laptop laptop2 = new IdeaPad();
        Predator predator = new Predator();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();
        laptop2.vga = new AMD();
        laptop2.processor = new Ryzen();
        predator.vga = new AMD();
        predator.processor = new CoreI7();



        //Soal 1
        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //Soal 2
        Console.WriteLine("\nSoal 2");
        //laptop1.Ngoding();

        //Soal 3
        Console.WriteLine("\nSoal 3");
        Console.WriteLine("Spesifikasi laptop 1 \n" + "Merk VGA : " + laptop1.vga + "\nMerk Processor : " + laptop1.processor.merk + "\nTipe Processor : " + laptop1.processor.tipe);

        //Soal 4
        Console.WriteLine("\nSoal 4");
        predator.BermainGame();

        //Soal 5
        Console.WriteLine("\nSoal 5");
        //ACER acer = new Predator();
        //acer.BermainGame();
    }
}


