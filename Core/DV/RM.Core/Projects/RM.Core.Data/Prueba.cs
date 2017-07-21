using RM.Core.Data.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Data
{
    public class Prueba: BizLogic
    {
        public string testCall()
        {
            string del = "";
            int a = 0;
            del = BizCall(
                new Action( () => 
                    {
                        a = dbContext.SYSInsertCatEventuality("Prueba", true);
                    }
                )
            );
            return del;
        }

    }
}
