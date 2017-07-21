﻿using System;

namespace RM.Core.Business.Entities.Views
{
    public class BizVisit
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int UserId { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string VisitName { get; set; }
        public string Carnet { get; set; }
        public string Plates { get; set; }
    }
}