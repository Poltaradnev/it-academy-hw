using System;

namespace hm_11
{
    enum MyFavoriteGenres
    {
        Techno = 1,
        Trance = 2,
        Rock = 3,
        Rap = 4,
        Punk = 5,
        Metal = 6,
        HipHop = 7,
        Folk = 8,
        Disco = 9,
    }
    struct Duration
    {
        private readonly int _NumberOfMinutes;
        private readonly int _NumberOfseconds;
        internal Duration(int minutes, int seconds)
        {
            _NumberOfMinutes = minutes;
            _NumberOfseconds = seconds;
        }
        internal int Minutes { get { return _NumberOfMinutes; } }
        internal int Seconds { get { return _NumberOfseconds; } }
        public override string ToString()
        {
            string duration = string.Format(_NumberOfMinutes.ToString("D_M") + ":" + _NumberOfseconds.ToString("D_S"));
            return duration;
        }
    }
    class SongData
    {
        private readonly string _NameSong = string.Empty;
        private readonly string _AuthorSong = string.Empty;
        private readonly Duration _DurationSong;
        private readonly int _YearOfIssueSong = 0;
        private readonly MyFavoriteGenres _myFavoriteGenres = 0;
        string NameSong { get { return _NameSong; } }
        string AuthorSong { get { return _AuthorSong; } }
        Duration Duration { get { return _DurationSong; } }
        int YearOfIssue { get { return _YearOfIssueSong; } }
        MyFavoriteGenres MyFavoriteGenres { get { return _myFavoriteGenres; } }
        SongData(string nameSong, string autorSong, Duration durationSong, int yearOfIssueSong, MyFavoriteGenres myFavoriteGenres)
        {
            _NameSong = nameSong;
            _AuthorSong = autorSong;
            _DurationSong = durationSong;
            _YearOfIssueSong = yearOfIssueSong;
            _myFavoriteGenres = myFavoriteGenres;
        }
        internal static dynamic GetSongData(SongData songData)
        {
            Console.WriteLine("Song info\n{0} - {1}, Duration - {2}, Song release year {3}, Genre: {4}", songData.NameSong, songData.AuthorSong, songData.Duration.ToString(), songData.YearOfIssue.ToString(), songData.MyFavoriteGenres);
            var songInfo = new
            {
                Title = songData.NameSong,
                Minute = songData.Duration.Minutes,
                AlbumYear = songData.YearOfIssue
            };
            return songInfo;
        }
        internal static void SetSongData(out SongData songData)
        {
            Console.WriteLine("Enter song title");
            string nameSong = Console.ReadLine();
            Console.WriteLine("Enter the artist of the song");
            string authorSong = Console.ReadLine();
            Console.WriteLine("Enter song duration");
            int minutes = 0;
            int seconds = 0;
            while (true)
            {
                string durationSongString = Console.ReadLine();
                string[] durationSongArray = durationSongString.Split(':');
                if (durationSongArray.Length == 2)
                {
                    if (int.TryParse(durationSongArray[0], out minutes) && int.TryParse(durationSongArray[1], out seconds) && minutes < 60 && seconds < 60)
                    {
                        break;
                    }
                }
                Console.WriteLine("Data entered incorrectly, re-enter");
            }
            Duration durationSong = new Duration(minutes, seconds);
            Console.WriteLine("Enter the year of creation");
            int yearOfIssueSong = 0;
            while (true)
            {
                string yearOfIssueSongString = Console.ReadLine();
                if (int.TryParse(yearOfIssueSongString, out yearOfIssueSong) && yearOfIssueSong < DateTime.Now.Year)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Year entered incorrectly, please try again");
                }
            }
            Console.WriteLine("Enter the song genre number above");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine((MyFavoriteGenres)i + "-" + i.ToString());
            }
            MyFavoriteGenres myFavoriteGenres;
            int genreMusicInt = 0;
            while (true)
            {
                string genreMusicString = Console.ReadLine();
                if (int.TryParse(genreMusicString, out genreMusicInt) && genreMusicInt < 24)
                {
                    myFavoriteGenres = (MyFavoriteGenres)genreMusicInt;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter the genre number incorrectly, please try again");
                }
            }
            songData = new SongData(nameSong, authorSong, durationSong, yearOfIssueSong, myFavoriteGenres);
        }
    }
}

