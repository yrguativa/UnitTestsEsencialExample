using Linkedin.DogMeasures.Exceptions;
using Linkedin.DogMeasuresDependencies.Test.FakeClasses;
using Linkedin.DogMeasuresDependencies.Models;
using Linkedin.DogMeasuresDependencies.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Linkedin.DogMeasuresDependencies
{
  [TestClass]
  public class DogMeasuresServiceShould
  {
    [TestMethod]
    [ExpectedException(typeof(BreedNotFoundException))]
    public void ThrowsBreedNotFoundException_IfBreedIsYorkshire()
    {
     
      /* Si se realiza el siguiente codigo se estaria convirtiendo en un Test de integracion,
       * es por tal motivo que se utiliza una clase Fake
       * var service = new DogMeasuresService(new FakeDogMeasuresRepository());*/
      var service = new DogMeasuresService(new FakeDogMeasuresRepository());
      var result = service.CheckDogIdealWeight("yorkshire", 14);
    }
  }
}
