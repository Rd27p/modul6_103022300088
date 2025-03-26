using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300088
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("A");
            video1.IncreasePlayCount(10);
            SayaTubeVideo video2 = new SayaTubeVideo("Star");
            video2.IncreasePlayCount(20);
            SayaTubeVideo video3 = new SayaTubeVideo("Wars");
            video3.IncreasePlayCount(30);
            SayaTubeVideo video4 = new SayaTubeVideo("Trek");
            video4.IncreasePlayCount(40);
            SayaTubeVideo video5 = new SayaTubeVideo("HEHE");
            video5.IncreasePlayCount(50);
            SayaTubeVideo video6 = new SayaTubeVideo("HEHE");
            video6.IncreasePlayCount(60);
            SayaTubeVideo video7 = new SayaTubeVideo("Chronic");
            video7.IncreasePlayCount(70);
            SayaTubeVideo video8 = new SayaTubeVideo("YES");
            video8.IncreasePlayCount(80);
            SayaTubeVideo video9 = new SayaTubeVideo("MAN");
            video9.IncreasePlayCount(90);
            SayaTubeVideo video10 = new SayaTubeVideo("TRI");
            video10.IncreasePlayCount(100);

            SayaTubeUser sayaTubeUser = new SayaTubeUser("Gusti Agung Raka Darma Putra Kepakisan");
            sayaTubeUser.addVideo(video1);
            sayaTubeUser.addVideo(video2);
            sayaTubeUser.addVideo(video3);
            sayaTubeUser.addVideo(video4);
            sayaTubeUser.addVideo(video5);
            sayaTubeUser.addVideo(video6);
            sayaTubeUser.addVideo(video7);
            sayaTubeUser.addVideo(video8);
            sayaTubeUser.addVideo(video9);
            sayaTubeUser.addVideo(video10);

            Console.WriteLine("Judul Film " + video1.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video2.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video3.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video4.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video5.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video6.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video7.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video8.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video9.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
            Console.WriteLine("Judul Film " + video10.getTitle() + " Oleh Gusti Agung Raka Darma Putra Kepakisan");
        }
    }
}
