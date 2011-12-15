using System;

namespace app.infrastructure.containers.simple
{
	public class SingleDependencyFactory : ICreateASingleDependency
	{
		private IMatchAType type_criteria;
	    private ICreateADependency _aDependency;

	    public SingleDependencyFactory(IMatchAType type_criteria, ICreateADependency aDependency)
	    {
	        _aDependency = aDependency;
	        this.type_criteria = type_criteria;
	    }

	    public object create()
	    {
	        return _aDependency.create();
	    }

		public bool can_create(Type type)
		{
			return type_criteria.matches(type);
		}
	}
}