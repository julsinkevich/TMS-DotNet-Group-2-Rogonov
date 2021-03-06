﻿using System;

namespace TMS.Nbrb.Core.Models
{
    /// <summary>
    /// Currency dynamics properties.
    /// </summary>
    public class Dynamics
    {
        public int Cur_ID { get; set; }
        public DateTime Date { get; set; }
        public double Cur_OfficialRate { get; set; }
    }
}
