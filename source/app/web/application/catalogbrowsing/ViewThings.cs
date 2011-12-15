using app.infrastructure;
using app.web.application.catalogbrowsing.stubs;
using app.web.core;
using app.web.core.stubs;

namespace app.web.application.catalogbrowsing
{
  public class ViewThings:ISupportAStory
  {
    IFindInformationInTheStore generic_catalog;
    IDisplayReports display_engine;

    public ViewThings(IFindInformationInTheStore store_catalog, IDisplayReports display_engine)
    {
      this.generic_catalog = store_catalog;
      this.display_engine = display_engine;
    }

    public void process(IProvideDetailsToCommands request)
    {
        string typeOfThings = "products";
      display_engine.display(generic_catalog.get_things(request.map<DepartmentItem>(), typeOfThings));
    }
  }
}