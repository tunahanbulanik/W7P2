using System;

namespace W7P2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List> singers = new List<List>()
            {
            new List { Name = "Ajda Pekkan", MusicType = "Pop", Year = 1968, AlbumSell = 20 },
            new List { Name = "Sezen Aksu", MusicType = "Türk Halk Müziği / Pop", Year = 1971, AlbumSell = 10 },
            new List { Name = "Funda Arar", MusicType = "Pop", Year = 1999, AlbumSell = 3 },
            new List { Name = "Sertab Erener", MusicType = "Pop", Year = 1994, AlbumSell = 5 },
            new List { Name = "Sıla", MusicType = "Pop", Year = 2009, AlbumSell = 3 },
            new List { Name = "Serdar Ortaç", MusicType = "Pop", Year = 1994, AlbumSell = 10 },
            new List { Name = "Tarkan", MusicType = "Pop", Year = 1992, AlbumSell = 40 },
            new List { Name = "Hande Yener", MusicType = "Pop", Year = 1999, AlbumSell = 7 },
            new List { Name = "Hadise", MusicType = "Pop", Year = 2005, AlbumSell = 5 },
            new List { Name = "Gülben Ergen", MusicType = "Pop", Year = 1997, AlbumSell = 10 },
            new List { Name = "Neşet Ertaş", MusicType = "Türk Halk Müziği / Türk Sanat Müziği", Year = 1960, AlbumSell = 2 }
        };
            var startsWithS = singers.Where(s => s.Name.StartsWith("S")).ToList();
            Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
            foreach (var s in startsWithS)
                Console.WriteLine(s.Name);

            Console.WriteLine();

            var aboveTenMillion = singers.Where(s => s.AlbumSell > 10).ToList();
            Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
            foreach (var s in aboveTenMillion)
                Console.WriteLine(s.Name);

            Console.WriteLine();

            var pre2000PopSingers = singers
          .Where(s => s.Year < 2000 && s.MusicType.Contains("Pop"))
          .OrderBy(s => s.Year).ThenBy(s => s.Name).ToList();
            Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
            foreach (var s in pre2000PopSingers)
                Console.WriteLine($"{s.Name} - {s.Year}");

            Console.WriteLine();

            var topSelling = singers.OrderByDescending(s => s.AlbumSell).First();
            Console.WriteLine($"En çok albüm satan şarkıcı: {topSelling.Name}");

            Console.WriteLine();

            var newest = singers.OrderByDescending(s => s.Year).First();
            var oldest = singers.OrderBy(s => s.Year).First();
            Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newest.Name}");
            Console.WriteLine($"En eski çıkış yapan şarkıcı: {oldest.Name}");
        }
    }
}