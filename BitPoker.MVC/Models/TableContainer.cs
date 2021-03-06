﻿using System;
using System.Collections.Generic;

namespace BitPoker.MVC.Models
{
    public class TableContainer
    {
        public ICollection<BitPoker.Models.Contracts.Table> Tables { get; set; }

        public TableContainer()
        {
            Tables = new List<BitPoker.Models.Contracts.Table>();
        }
    }
}
