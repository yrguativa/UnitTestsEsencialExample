using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linkedin.DogMeasuresDependencies.Contracts;
using Newtonsoft.Json;

namespace Linkedin.DogMeasuresDependencies.Repositories
{
	public class DogMeasuresRepository : IDogMeasuresRepository
	{

		private readonly List<Models.DogMeasures> _measures;

		public DogMeasuresRepository()
		{
			string jsonFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DogMeasures.json");
			_measures = JsonConvert.DeserializeObject<List<Models.DogMeasures>>(File.ReadAllText(jsonFile, Encoding.UTF8));
		}

		public virtual Models.DogMeasures GetMeasures (string breed)
		{
			return _measures.SingleOrDefault(r => r.Breed.Equals(breed, StringComparison.InvariantCultureIgnoreCase));
		}

	}
}
