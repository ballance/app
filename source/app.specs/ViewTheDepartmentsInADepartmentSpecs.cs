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
      It it_should_show_departments_in_a_main_department = () =>        
        
    }
  }
}
