﻿using System;

namespace RM.Core.Business.Entities.Views
{
    public class BizInternalExpense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
