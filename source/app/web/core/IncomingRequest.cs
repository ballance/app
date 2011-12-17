using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.web.core
{
    public class IncomingRequest
    {
        public static RequestCommand was()
        {
            throw new NotImplementedException();
        }

        public RequestCommand made_for<IViewItemsInDepartment>()
        {
            throw new NotImplementedException();
        }
    }

    public interface IRequestCriteria
    {
        RequestCommand was();

        RequestCommand made_for<IViewItemsInDepartment>();
    }
}
