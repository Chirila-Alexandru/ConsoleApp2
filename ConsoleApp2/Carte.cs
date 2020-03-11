using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
	internal class Carte
	{
		private
		string nume, autor;
		int nr_exemplare;
		public 
			Carte()
		{
			nume = "";
			autor = "";
			nr_exemplare=0;

		}

		Carte(string n,string a,int nr)
		{
			nume = n;
			autor = a;
			nr_exemplare = nr;
		}
		public void SetNume(string a)
		{
			nume = a;

		}
		public string GetNume()
		{
			return nume;
		}
		public void SetAutor(string a)
		{
			autor = a;

		}
		public string GetAutor()
		{
			return autor;
		}
		public void SetNr(int a)
		{
			nr_exemplare = a;

		}
		public int GetExemplare()
		{
			return nr_exemplare;
		}
		public void DisplayInfo()
		{
			System.Console.WriteLine("Nume\tAutor\tNr.Exemplare");
			System.Console.WriteLine(nume+"\t"+autor+"\t"+nr_exemplare);
		}
	}


}
