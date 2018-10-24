using Linkedin.DogMeasuresDependencies.Repositories;
using Linkedin.DogMeasuresDependencies.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Linkedin.DogMeasuresDependencies.Services;
using System;

namespace Linkedin.DogMeasuresDependecies.MoqTest
{ 
    [TestClass]
    public class DogMeasuresServiceShould
    {

      private Mock<DogMeasuresRepository> _mockRepository;

      [TestInitialize]
      public void Setup()
      {
        _mockRepository = new Mock<DogMeasuresRepository>();
        var dogsMeasures = new List<DogMeasuresDependencies.Models.DogMeasures> {
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "afgano", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Akita", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "American Bully", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "American Foxhound", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "American Pitbull Terrier", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Beagle", RecommendedMinWeight = 8, RecommendedMaxWeight = 14, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Bichón Frisé", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Bichón Maltés", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Bodeguero Andaluz", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Border Collie", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Border Terrier", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Bóxer", RecommendedMinWeight = 20, RecommendedMaxWeight = 40, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Bulldog", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Caniche", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Chihuahua", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Chow Chow", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Golden Retriever", RecommendedMinWeight = 20, RecommendedMaxWeight = 28, LifeExpectancy = 14 },
                new DogMeasuresDependencies.Models.DogMeasures { Breed = "Labrador Retriever", RecommendedMinWeight = 20, RecommendedMaxWeight = 35, LifeExpectancy = 14 }
            };

        _mockRepository.Setup(m => m.GetMeasures(It.IsAny<string>())).Returns<string>((breed) =>
        {
          return dogsMeasures.SingleOrDefault(m => m.Breed.Equals(breed, StringComparison.InvariantCultureIgnoreCase));
        });

      }

      [TestMethod]
      public void DogIsInOverweight_IfBreedIsBoxerAndWeightIs50()
      {
        var service = new DogMeasuresService(_mockRepository.Object);
        var result = service.CheckDogIdealWeight("bóxer", 50);
        Assert.IsTrue(result.DeviationType == DogMeasuresDependencies.Models.DogWeightInfo.WeightDeviationType.Overweight);
      }

    }
  
}
