using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {start:
            Console.WriteLine("Zed Gragas ve Yasuo adlı oyunculardan bir tanesini seçiniz : ");
            string oyuncu =Console.ReadLine();
            string Oyuncu = oyuncu.ToLower();
            if (Oyuncu== "zed") 
            {
                karakter a1 = new Zed();
                a1.Template();
            }
            else if(Oyuncu=="gragas")
            {
                karakter a2 = new Gragas();
                a2.Template();
            }
            else if (Oyuncu == "yasuo")
            {
                karakter a3 = new Yasuo();
                a3.Template();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Lütfen verilen karakter isimlerinden bir tanesini doğru şekilde yazdığınızdan veya boşluk bırakmadığınızdan emin olunuz");
                Console.ReadKey();
                Console.Clear();
                goto start;
            }
            Console.ReadKey();
        }

        public enum character
        {
            Zed, Gragas, Yasuo
        }
        public abstract class karakter
        {
            protected string Karakter;
            protected character Char;
            void bitir() => Console.WriteLine($"Karakter seçiminiz tammalanmıştır {Karakter} isimli karakteri seçmişsinizdir.");

            abstract public void Character();
            abstract public void name();
            public void Template()
            {
                Character();
                name();
                bitir();
            }
        }
        public class Zed : karakter
        {
            public override void Character()
            {
                Char = character.Zed;
            }
            public override void name()
            {
                Karakter = "Zed";
            }

        }
        public class Gragas : karakter
        {
            public override void Character()
            {
                Char = character.Gragas;
            }
            public override void name()
            {
                Karakter = "Gragas";
            }

        }
        public class Yasuo : karakter
        {
            public override void Character()
            {
                Char = character.Yasuo;
            }
            public override void name()
            {
                Karakter = "Yasuo";
            }

        }
    }
}
