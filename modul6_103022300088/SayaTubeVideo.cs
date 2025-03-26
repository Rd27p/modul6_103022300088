using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(judulVideo != null, "Judul video tidak boleh null");
            Debug.Assert(judulVideo.Length <= 200, "Judul video tidak boleh lebih dari 200 kata");
            Random rnd = new Random();
            this.id = rnd.Next(100000, 999999);
            this.title = judulVideo;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0, "Play count tidak boleh negatif");
            Debug.Assert(count <= 2500000, "Play count tidak boleh lebih dari 1.000.000");
            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Play count melebihi batas maksimum");
            }
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
