using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraHora.Models
{
    public class Calculo
    {

        public int idTransaction { get; set; }

        public double result { get; set; }

        public DateTime executionHour { get; set; }

        public double totalValue { get; set; }

        public double hourPerDay { get; set; }

        public double daysPerWeek { get; set; }

        public double vacationDays { get; set; }

    }
}