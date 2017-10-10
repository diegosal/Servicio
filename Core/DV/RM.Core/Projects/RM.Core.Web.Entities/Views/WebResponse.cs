using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Web.Entities.Views
{
    public class WebResponse<T,M>
    {
        public T Model { get; set; }
        public M Response { get;set; }
    }
}
