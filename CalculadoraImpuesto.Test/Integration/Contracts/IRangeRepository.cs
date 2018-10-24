using Integration.Entities;

namespace Integration.Contracts
{
  public interface IRangeRepository
	{

		Range GetRange(decimal grossSalary);
	}
}
