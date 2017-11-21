﻿using System;

namespace RM.Core.Business.Entities.Views
{
    public class WebAssistControl
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    }
}