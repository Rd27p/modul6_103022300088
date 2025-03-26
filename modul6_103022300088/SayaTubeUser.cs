using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300088
{
    class SayaTubeUser
    {
        private int id;
        private  List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Random rnd = new Random();
            this.id = rnd.Next(100000, 999999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int count = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                count += video.getplayCount();
            }
            return count;
        }

        public void addVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul: " + uploadedVideos[i].getTitle + " dengan Play Count " + uploadedVideos[i].getplayCount);
            }
        }
    }
}
