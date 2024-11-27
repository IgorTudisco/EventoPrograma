using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppEventoPrograma.Models
{
    public class Evento
    {

        public String? Nome { get; set; }


        public DateTime DataInicio {get; set;}

        public DateTime DataTermino {get; set;}

        public int Participantes {get; set;}

        public String? Local {get; set;}

        public double CustoParticipante {get; set;}

         

        public int Duracao
        {

            get
            {

                TimeSpan intervalo = DataTermino - DataInicio;
                return Convert.ToInt32(intervalo.Days);

            }

        }

        public double Total

        {

            get {
                double total = Participantes * CustoParticipante * Duracao;
                return total;
            
                     }

        }

        



    }
}
