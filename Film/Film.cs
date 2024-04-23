using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace SerializeDeserialize
{
    [Serializable]
    public class Film
    {
        public string Tytul { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
        public double Ocena { get; set; }



        public Film()
        {



        }
        public Film(string tytul, int rokWydania, string gatunek, double ocena)
        {
            Tytul = tytul;
            RokWydania = rokWydania;
            Gatunek = gatunek;
            Ocena = ocena;
        }
    }



    [Serializable]
    public class ListaFilmow
    {
        public ListaFilmow()
        {



        }
        public List<Film> filmy = new List<Film>();



        public void Generate()
        {



            filmy.Add(new Film("The Shawshank Redemption", 1994, "Dramat", 9.3));
            filmy.Add(new Film("The Godfather", 1972, "Dramat", 9.2));
            filmy.Add(new Film("The Dark Knight", 2008, "Akcja", 9.0));
            filmy.Add(new Film("Schindler's List", 1993, "Biograficzny", 8.9));
            filmy.Add(new Film("The Lord of the Rings: The Return of the King", 2003, "Fantasy", 8.9));
            filmy.Add(new Film("Pulp Fiction", 1994, "Kryminał", 8.9));
            filmy.Add(new Film("The Lord of the Rings: The Fellowship of the Ring", 2001, "Fantasy", 8.8));
            filmy.Add(new Film("Forrest Gump", 1994, "Dramat", 8.8));
            filmy.Add(new Film("Fight Club", 1999, "Dramat", 8.8));
            filmy.Add(new Film("Inception", 2010, "Sci-Fi", 8.7));
            filmy.Add(new Film("The Lord of the Rings: The Two Towers", 2002, "Fantasy", 8.7));
            filmy.Add(new Film("Star Wars: Episode V - The Empire Strikes Back", 1980, "Sci-Fi", 8.7));
            filmy.Add(new Film("The Matrix", 1999, "Sci-Fi", 8.7));
            filmy.Add(new Film("Goodfellas", 1990, "Biograficzny", 8.7));
            filmy.Add(new Film("One Flew Over the Cuckoo's Nest", 1975, "Dramat", 8.7));
            filmy.Add(new Film("Se7en", 1995, "Kryminał", 8.6));
            filmy.Add(new Film("The Silence of the Lambs", 1991, "Kryminał", 8.6));
            filmy.Add(new Film("City of God", 2002, "Dramat", 8.6));
            filmy.Add(new Film("The Green Mile", 1999, "Dramat", 8.6));
            filmy.Add(new Film("The Usual Suspects", 1995, "Kryminał", 8.5));
            filmy.Add(new Film("Léon: The Professional", 1994, "Akcja", 8.5));
            filmy.Add(new Film("Saving Private Ryan", 1998, "Wojenny", 8.5));
            filmy.Add(new Film("Interstellar", 2014, "Sci-Fi", 8.5));
            filmy.Add(new Film("The Pianist", 2002, "Biograficzny", 8.5));
            filmy.Add(new Film("Gladiator", 2000, "Akcja", 8.5));
            filmy.Add(new Film("American History X", 1998, "Dramat", 8.5));
            filmy.Add(new Film("The Departed", 2006, "Kryminał", 8.5));
            filmy.Add(new Film("Whiplash", 2014, "Dramat", 8.5));
            filmy.Add(new Film("The Lion King", 1994, "Animacja", 8.5));
            filmy.Add(new Film("The Prestige", 2006, "Mystery", 8.5));
            filmy.Add(new Film("The Intouchables", 2011, "Biograficzny", 8.5));
            filmy.Add(new Film("The Godfather: Part II", 1974, "Dramat", 8.5));
            filmy.Add(new Film("The Sixth Sense", 1999, "Thriller", 8.5));
            filmy.Add(new Film("The Departed", 2006, "Kryminał", 8.5));
            filmy.Add(new Film("The Shining", 1980, "Horror", 8.4));
            filmy.Add(new Film("The Truman Show", 1998, "Dramat", 8.4));
            filmy.Add(new Film("The Dark Knight Rises", 2012, "Akcja", 8.4));
            filmy.Add(new Film("The Lives of Others", 2006, "Dramat", 8.4));
            filmy.Add(new Film("The Help", 2011, "Dramat", 8.4));
            filmy.Add(new Film("The Terminator", 1984, "Sci-Fi", 8.4));
            filmy.Add(new Film("The Matrix", 1999, "Sci-Fi", 8.4));
            filmy.Add(new Film("The Silence of the Lambs", 1991, "Kryminał", 8.4));
        }
    }
}