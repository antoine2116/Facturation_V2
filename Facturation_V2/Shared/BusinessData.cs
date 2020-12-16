using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation_V2.Shared
{
    public class BusinessData : IBusinessData
    {
        public List<Facture> lesFactures { get; }

        public BusinessData()
        {
            var facture1 = new Facture("Paul Ducours", "F1120-0030", "13/01/2020", "12/02/2020", 1600, 1400);
            var facture2 = new Facture("Didier Dupuis", "F1120-0031", "14/02/2020", "20/05/2020", 4000, 100);
            var facture3 = new Facture("Fayat Construction", "F1120-0032", "01/10/2020", "30/11/2020", 14500, 5000);
            var facture4 = new Facture("Pierre Renovation", "F1120-0033", "12/12/2020", "04/05/2021", 1500, 200);
            var facture5 = new Facture("Michel Destruction", "F1120-0034", "25/12/2020", "01/01/2021", 4000, 2433);
            var facture6 = new Facture("Patrick Peinture", "F1120-0035", "27/12/2020", "24/02/2021", 6000, 432);
            lesFactures = new List<Facture> { facture1, facture2, facture3, facture4, facture5, facture6 };
        }
    }
}
