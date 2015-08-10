﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catalog.DTO
{
	public class DtoRetorno
	{
		public string tipoRetorno { get; set; }
		public string destino { get; set; }

		public DtoRetorno(string tipoRetorno, string destino = "this")
		{
			this.tipoRetorno = tipoRetorno;
			this.destino = destino;
		}
	}
}