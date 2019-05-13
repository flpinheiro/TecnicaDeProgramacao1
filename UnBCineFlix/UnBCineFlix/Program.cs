using System;
using UnBCineFlix.Model;

namespace UnBCineFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt = new MovieTheater(10,10);
            mt.AddChair(new Chair(5,5));
            mt.AddChair(new Chair(3,6,true));

            Console.Write(mt);

            var movie = new Movie();
            movie.Title = "It, a coisa";
            movie.ReleaseDate = new DateTime(2019,09,5);
            movie.Genre = "Terror, Thriller";
            movie.Rating = new Rating("NC-17", 17);
            movie.Synopsis = "Vinte e sete anos depos, o clube dos perdedores cresceu e se mudou, depois de um telefonema devastador eles irão retornar.";
            movie.ArtistList.Add(new Artist("james McAvoy"));
            movie.ArtistList.Add(new Artist("Javier Botet"));
            movie.ArtistList.Add(new Artist("Jessica Chastain"));
            movie.DirectorList.Add(new Artist("Andy Muschietti"));
            Console.WriteLine(movie);
            Console.WriteLine("UnB Cine Flix");
            
        }
    }
}
