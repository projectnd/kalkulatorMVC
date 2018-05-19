using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalkulator.Models
{
    public enum Operacija
    {
        Zbrajanje ='+',
        Oduzimanje = '-',
        Mnozenje ='*',
        Dijeljenje = '/'
    }
    public class KalkulatorModel
    {
        public decimal PrviOperand { get; set; }
        public decimal DrugiOperand { get; set; }
        public Operacija Operacija { get; set; }
        public decimal Rezultat { get; set; }

    }
}