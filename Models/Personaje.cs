using System.Globalization;

namespace BlazorApp1.Models
{
    public class Personaje
    {
        public string nombre { get; set; }= string.Empty;
        public int nivel { get; set; }
        public double ptsvida { get; set; }
        public int exp {  get; set; }
    }
}
