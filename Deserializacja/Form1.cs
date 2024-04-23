using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Deserializacja
{
    public partial class Form1 : Form
    {
        private List<Ksiazka> listaKsiazek = new List<Ksiazka>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            Ksiazka nowaKsiazka = new Ksiazka
            {
                Autor = textBox2.Text,
                Tytul = textBox1.Text,
                DataWydania = textBox3.Text,
            };
            listaKsiazek.Add(nowaKsiazka);
            listBox1.Items.Add($"Tytuł: {nowaKsiazka.Tytul} - Autor: {nowaKsiazka.Autor} - Data Wydania: {nowaKsiazka.DataWydania}");

            AktualizujListBox();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void deserializujBnt_Click(object sender, EventArgs e)
        {
            string filePath = "ksiazki.xml";

            if (File.Exists(filePath))
            {
                listaKsiazek = SerializerForXml.DeserializeFromXml<List<Ksiazka>>(filePath);
                MessageBox.Show("Deserializacja zakończona pomyślnie.");

                // Wyświetl listę książek w konsoli
                Console.WriteLine("Lista książek:");
                foreach (var ksiazka in listaKsiazek)
                {
                    Console.WriteLine($"Tytuł: {ksiazka.Tytul}, Autor: {ksiazka.Autor}, Data wydania: {ksiazka.DataWydania}");
                }
                AktualizujListBox();
            }
            else
            {
                MessageBox.Show("Podany plik XML nie istnieje.");
            }
        }

        private void AktualizujListBox()
        {
            listBox1.Items.Clear();
            foreach (var ksiazka in listaKsiazek)
            {
                listBox1.Items.Add($"Tytuł: {ksiazka.Tytul} - Autor: {ksiazka.Autor} - Data Wydania: {ksiazka.DataWydania}");
            }
        }
    }

    public class Ksiazka
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public string DataWydania { get; set; }
    }

    public class SerializerForXml
    {
        public static void SerializeToXml<T>(T obj, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static T DeserializeFromXml<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StreamReader(filePath))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
