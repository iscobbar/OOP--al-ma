using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_sorular
{
    /* interface: 
     * beyaz eşya: enerki sınıfı , renk, ağırlık, en ,boy, yükseklik , derinlik, 
     * ekran; çözünürlük, renk sayisi,LEDMİ ,LCDmi
     * 
     * sınıflar: 
     * buzdolabı: hacim; raf sayisi,donduruvarmı,nofrostvarmi
     * çamaşırmakinesi, kapasite, deterjanbolumsayisi, kurutmavarmı
     * televizyon: uyduvarmı, smartmi
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            televizyon t1 = new televizyon();
            t1.led_mi = true;
            t1.renksayisi = "10.000.000";
            t1.çözünürlük = "1950x3350";
            t1.enerjisinifi = enerjisinifi.A;

            buzdolabı b1 = new buzdolabı();
            b1.beyazeşyalar = beyazeşyalar.samsung;
            b1.agirlik = 400;
            b1.boy = 2.20f;
            b1.en = 0.35f;
            b1.enerjisinifi = enerjisinifi.A;

            çamaşırmakinesi ç1 = new çamaşırmakinesi();
            ç1.beyazeşyalar = beyazeşyalar.bosh;
            ç1.enerjisinifi = enerjisinifi.A;
            ç1.agirlik = 250;



            Console.WriteLine($"led varmı?: {t1.led_mi}\nKaç Renk vardır?: {t1.renksayisi}\nÇözünürlük: {t1.çözünürlük}\nEnerji Sınıfı: {t1.enerjisinifi}");


            Console.Read();
        }

        interface beyazeşya
        {
            float derinlik { get; set; }
            float genişlik { get; set; }
            float boy { get; set; }
            float en { get; set; }
            int agirlik { get; set; }
            enerjisinifi enerjisinifi { get; set; }
            beyazeşyalar beyazeşyalar { get; set; }
        }
        interface ekran
        {
            bool led_mi { get; set; }
            bool smart_mi { get; set; }
            string renksayisi { get; set; }
            string çözünürlük { get; set; }
            ekranlar ekranlar { get; set; }
        }
        public class buzdolabı : beyazeşya
        {
            int hacim;
            byte raf_sayisi;
            bool dondurucu_var_mi = false;
            bool no_frost_var_mi = false;

            public float derinlik { get; set; }
            public float genişlik { get; set; }
            public float boy { get; set; }
            public float en { get; set; }
            public int agirlik { get; set; }
            public enerjisinifi enerjisinifi { get; set; }
            public beyazeşyalar beyazeşyalar { get; set; }
        }
        public class çamaşırmakinesi : beyazeşya
        {
            double ÇamaşırKapasitesi;
            byte deterjanbölümsayisi;
            bool kurutma_var_mi = false;
            public float derinlik { get; set; }
            public float genişlik { get; set; }
            public float boy { get; set; }
            public float en { get; set; }
            public int agirlik { get; set; }
            public enerjisinifi enerjisinifi { get; set; }
            public beyazeşyalar beyazeşyalar { get; set; }
        }
        public class televizyon : ekran,beyazeşya
        {
            bool uyduvar_mi = false;
            bool smart_mi = false;
            public bool led_mi { get; set; }
            bool ekran.smart_mi { get; set; }
            public string renksayisi { get; set; }
            public string çözünürlük { get; set; }
            public ekranlar ekranlar { get; set; }
            bool ekran.led_mi { get; set; }
            public float derinlik { get; set; }
            public float genişlik { get; set; }
            public float boy { get; set; }
            public float en { get; set; }
            public int agirlik { get; set; }
            public enerjisinifi enerjisinifi { get; set; }
            public beyazeşyalar beyazeşyalar { get; set; } 
}
        public enum beyazeşyalar
        {
            bosh, arçelik, beko, siemens, samsung
        }
        public enum ekranlar
        {
            sony, exper, noc, philips, siemens, lg
        }
        public enum enerjisinifi
        {
            A, B, C, D, E
        }
        public enum renk
        {
            sari, mavi, kırmızı, mor, siyah, beyaz, gri, lacivert, yeşil, bordo
        }
    }
}
