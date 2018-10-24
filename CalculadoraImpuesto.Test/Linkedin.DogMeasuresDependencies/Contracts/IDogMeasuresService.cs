using Linkedin.DogMeasuresDependencies.Models;

namespace Linkedin.DogMeasuresDependencies.Contracts
{
  public interface IDogMeasuresService
	{

		DogWeightInfo CheckDogIdealWeight(string breed, decimal weight);

		int GetLifeExpectancy(string breed);

	}
}
