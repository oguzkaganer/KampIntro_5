namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MevzuatBase aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();


            Console.ReadLine();
        }
    }

    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }

        protected MevzuatBase()
        {
            Console.WriteLine("Çalışıyor.");
        }
    }



    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatı...");
        }

    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            throw new NotImplementedException();
        }
    }
}