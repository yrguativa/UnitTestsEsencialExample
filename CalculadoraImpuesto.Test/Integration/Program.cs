using Integration.Repositories;
using Integration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Salario bruto anual:");
      var grossStr = Console.ReadLine();
      if (!Decimal.TryParse(grossStr, out decimal gross))
      {
        Console.WriteLine("No es un valor válido. Pulsa enter para salir.");
        Console.ReadLine();
        return;
      }
      var taxService = new TaxService(new RangeRepository());
      Console.WriteLine($"Vas a pagar {taxService.GetTaxes(gross)}.");
      Console.ReadLine();
    }
  }
}
