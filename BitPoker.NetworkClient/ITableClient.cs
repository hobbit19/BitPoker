﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BitPoker.NetworkClient
{
	public interface ITableClient
	{
		Task<IEnumerable<Models.Contracts.Table>> GetTablesAsync();
	}
}