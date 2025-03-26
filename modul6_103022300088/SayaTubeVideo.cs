using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300088
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string judulVideo)
        {
            Random rnd = new Random();
            this.id = rnd.Next(100000, 999999);
            this.title = judulVideo;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public int getplayCount()
        {
            return this.playCount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
