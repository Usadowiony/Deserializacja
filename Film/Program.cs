using SerializeDeserialize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.WebRequestMethods;



namespace Lab6Serializacja
{
    internal class Program
    {
        public class SerializerForXml
        {
            // Serializacja do XML
            public static void SerializeToXml<T>(T obj, string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextWriter writer = new StreamWriter(filePath))
                {
                    serializer.Serialize(writer, obj);
                }
            }
            // Deserializacja z XML
            public static T DeserializeFromXml<T>(string filePath)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(filePath))
                {
                    return (T)serializer.Deserialize(reader);
                }
            }
        }

        public class Ksiazka
        {
            public string Tytul { get; set; }
            public string Autor { get; set; }
            //public int RokWydania { get; set; }
            //public string Gatunek { get; set; }
            //public double Ocena { get; set; }
            public Ksiazka(string tytul, string autor)
            {
                Tytul = tytul;
                Autor = autor;
            }
        }
        public class ListaKsiazek
        {
            public ListaKsiazek()
            {

            }
            public List<Ksiazka> ksiazka = new List<Ksiazka>();
            public void Generate()
            {
                ksiazka.Add(new Ksiazka("The Shawshank Redemption", "Dramat"));
            }

            static void Main(string[] args)
            {
                
                ListaKsiazek listaKsiazek = new ListaKsiazek();
                listaKsiazek.Generate();



                //Serializacja do XML
                string xmlFilePath = "ksiazkaxml.xml";
                SerializerForXml.SerializeToXml(listaKsiazek, xmlFilePath);
                Console.WriteLine($"Serialized to XML: {xmlFilePath}");



                // Deserializacja z XML
                ListaFilmow deserializedFilmFromXml = SerializerForXml.DeserializeFromXml<ListaFilmow>(xmlFilePath);



            }
        }
    }
}