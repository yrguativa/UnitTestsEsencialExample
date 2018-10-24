using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linkedin.DogMeasuresDependencies.Contracts
{
	public interface IDogMeasuresRepository
	{
		Models.DogMeasures GetMeasures(string breed);
	}
}
