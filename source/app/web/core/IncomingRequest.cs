using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.web.core
{
    public class IncomingRequest
    {
        public static RequestCriteria was
        { 
            get
            {
                throw new NotImplementedException();
            } 
            set { }
        }

        public RequestCriteria made_for<IViewItemsInDepartment>()
        {
            throw new NotImplementedException();
        }
    }
}