using System;
using System.Collections.Generic;

namespace app.infrastructure.containers.simple
{
  public class DependencyFactories : IFindFactoriesThatCanCreateDependencies
  {
      private IEnumerable<ICreateASingleDependency> dependencies;

      public DependencyFactories(IEnumerable<ICreateASingleDependency> dependencies)
      {
          this.dependencies = dependencies;
      }

      public ICreateASingleDependency get_factory_that_can_create(Type dependency)
      {
          ICreateASingleDependency toReturn = null; 
          foreach(var eachDependency in this.dependencies)
          {
              if (eachDependency.can_create(dependency))
                  toReturn =  eachDependency;
          }
          return toReturn;
      }
  }
}