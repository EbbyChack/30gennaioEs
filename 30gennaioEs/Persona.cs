using System;
namespace _30gennaioEs
{
	public class Persona
	{
	
		public string nome { get; set; }
		public string cognome { get; set; }
        public int età { get; set; }

		public string getNome()
		{
			return nome;
		}

        public string getCognome()
        {
            return cognome;
        }

        public int getEtà()
        {
            return età;
        }

        public string getDettagli()
        {
            return (nome +" "+ cognome+ " ha "+età+" anni.");
        }
    }
}

