﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Core.Web.Entities.Views
{
    public class TokenUser
    {
       public int Id { get; set; }
       public string UserName { get; set; }
       public string Name { get; set; }
       public string Token { get; set; }
    }
}
