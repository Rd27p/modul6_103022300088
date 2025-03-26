using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.Assert(username != null, "Username tidak boleh null");
            Debug.Assert(username.Length <= 100, "Username tidak boleh lebih dari 100 kata");
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
            Debug.Assert(video != null, "Video tidak boleh null");
            Debug.Assert(video.getplayCount() > 20000000, "PlayCount kurang dari bilang integer maksimal");
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
