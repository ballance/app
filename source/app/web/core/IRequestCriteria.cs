using app.web.application.catalogbrowsing;

namespace app.web.core
{
    public interface IRequestCriteria
    {
        RequestCommand was();

        RequestCommand made_for<T>();
    }
}