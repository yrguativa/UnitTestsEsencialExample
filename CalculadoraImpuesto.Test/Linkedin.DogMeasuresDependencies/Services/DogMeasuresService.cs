using System;
using Linkedin.DogMeasuresDependencies.Contracts;
using Linkedin.DogMeasures.Exceptions;
using Linkedin.DogMeasuresDependencies.Models;

namespace Linkedin.DogMeasuresDependencies.Services
{
  public class DogMeasuresService : IDogMeasuresService
	{
		private readonly IDogMeasuresRepository _repository;

		public DogMeasuresService(IDogMeasuresRepository repository)
		{
			_repository = repository;
		}

		public DogWeightInfo CheckDogIdealWeight(string breed, decimal weight)
		{
			if (breed == null)
			{
				throw new ArgumentNullException(nameof(breed));
			}
			if (weight <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(weight));
			}
			var dog = _repository.GetMeasures(breed);
			if (dog == null)
			{
				throw new BreedNotFoundException("No se encontró esa raza.");
			}
			if (weight > dog.RecommendedMaxWeight)
			{
				var deviation = weight - dog.RecommendedMaxWeight;
				return new DogWeightInfo { DeviationType = DogWeightInfo.WeightDeviationType.Overweight, Message = $"Tu perro se pasa del peso ideal por {deviation} KG.", WeightDeviation = deviation };
			}
			else if (weight < dog.RecommendedMinWeight)
			{
				var deviation = dog.RecommendedMinWeight - weight;
				return new DogWeightInfo
				{
					DeviationType = DogWeightInfo.WeightDeviationType.BelowWeight,
					Message = $"Creo que deberías darle un poco más de comer  a tu perro! " +
					$"Debería engordar {deviation} KG para empezar a estar en su peso ideal.",
					WeightDeviation = deviation
				};
			}
			return new DogWeightInfo { Message = "¡Tu perro está en su peso ideal! ¡Enhorabuena!", DeviationType = DogWeightInfo.WeightDeviationType.InRange, WeightDeviation = 0m };
		}

		public int GetLifeExpectancy(string breed)
		{
			var dog = _repository.GetMeasures(breed);
			if (dog == null)
			{
				throw new BreedNotFoundException("No se encontró esa raza.");
			}
			return dog.LifeExpectancy;
		}

    
  }
}
