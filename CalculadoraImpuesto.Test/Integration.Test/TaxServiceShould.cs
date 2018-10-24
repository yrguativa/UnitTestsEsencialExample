using System;
using Integration.Repositories;
using Integration.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integration.Test
{
  [TestClass]
  public class TaxServiceShould
  {
    [TestMethod]
    public void Returns1805IfGrossSalaryIs9500()
    {
      var taxService = new TaxService(new RangeRepository());
      Assert.AreEqual(1805, taxService.GetTaxes(9500));
    }

    [TestMethod]
    public void Returns4680IfGrossSalaryIs19500()
    {
      var taxService = new TaxService(new RangeRepository());
      Assert.AreEqual(4680, taxService.GetTaxes(19500));
    }
  }
}
