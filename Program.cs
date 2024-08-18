using System;


public class Film
{
    public string filmAdi { get; set; }
    public double ImdbPuanı { get; set; }

    public Film(string _filmAdi, double _imdbpuani)
    {
        filmAdi = _filmAdi;
        ImdbPuanı = _imdbpuani;
    }

}
class Program
{


    static void Main()
    {

        List<Film> filmler = new List<Film>();

        bool devamet = true;

        while (devamet)
        {
            Console.WriteLine("Film İsmi : ");
            string isim = Console.ReadLine();
            Console.WriteLine("İmdb Puanı :");
            double imdbPuan = double.Parse(Console.ReadLine());
            filmler.Add(new Film(isim, imdbPuan));
            Console.WriteLine("Başka Bir Film Eklemek İster misiniz (evet/hayır)");
            string cevap = Console.ReadLine().ToLower();
            devamet = cevap == "evet";

        }

        Console.WriteLine("Tüm Filmler");
        foreach (var film in filmler)
        {
            Console.WriteLine($"İsim {film.filmAdi} Imdb Puanı : {film.ImdbPuanı}");
        }

        Console.WriteLine("IMDb Puanı 4 ile 9 arası filmler");
        var filtreliFilmler = filmler.Where(f => f.ImdbPuanı >= 4 && f.ImdbPuanı <= 9);

        foreach (var film in filtreliFilmler)
        {
            Console.WriteLine($"İsim : {film.filmAdi}, Imdb Puanı : {film.ImdbPuanı}");
        }

        Console.WriteLine("A ile Başlayan Filmler");
        var aIleBaslayanFilmler = filmler.Where(f => f.filmAdi.StartsWith("A", StringComparison.OrdinalIgnoreCase));

        foreach (var film in aIleBaslayanFilmler)
        {
            Console.WriteLine($"İsim: {film.filmAdi}, IMDb Puanı: {film.ImdbPuanı}");
        }


    }
}


