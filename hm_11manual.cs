using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace hm_11main
{
    class Program
    {
        static void Main(string[] args)
        {
            SongData songData;
            SongData.SetSongData(out songData);
            var JsonDataSong = JsonConvert.SerializeObject(SongData.GetSongData(songData));
            Console.WriteLine(JsonDataSong);
            Console.Read();
        }
    }
}
