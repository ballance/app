 using System.Collections.Generic;
 using Machine.Specifications;
 using app.web.application.catalogbrowsing;
 using app.web.core;
 using developwithpassion.specifications.rhinomocks;
 using developwithpassion.specifications.extensions;

namespace app.specs
{  
  [Subject(typeof(ViewTheDepartmentsInADepartment))]  
  public class ViewTheDepartmentsInADepartmentSpecs
  {
    public abstract class concern : Observes<ISupportAStory,
                                      ViewTheDepartmentsInADepartment>
    {
        
    }

   
    public class when_run : concern
    {
        private Establish c = () =>
        {
            department_repository = depends.on<IFindDepartments>();
            display_engine = depends.on<IDisplayReports>();
            request = fake.an<IProvideDetailsToCommands>();
            the_main_departments = new DepartmentItem();
            the_sub_departments = new List<DepartmentItem> {new DepartmentItem()};




        };

      It it_should_show_departments_in_a_main_department = () =>
        display_engine.received(x => x.display(the_main_departments));

      static IFindDepartments department_repository;
      static IProvideDetailsToCommands request;
      static IDisplayReports  display_engine;
      static IEnumerable<DepartmentItem> the_main_departments;

        
        static IEnumerable<DepartmentItem> the_sub_departments;
    }
  }
}
