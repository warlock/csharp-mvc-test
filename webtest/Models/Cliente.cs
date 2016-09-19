using System;
using System.Collections.Generic;

namespace webtest.Models
{
	public class Cliente
	{
		public int id { get; set; }
		public string nombre { get; set; }

		public static List<Cliente> Listar()
		{
			var clientes = new List<Cliente>();
			for (var i = 0; i < 10; i++)
			{
				clientes.Add(new Cliente()
				{
					id = i,
					nombre = "Cliente " + i
				});
			}
			return clientes;
		}

		public static Cliente Obtener()
		{
			return new Cliente
			{
				id = 1,
				nombre = "Cliente 1"
			};
		}

	}

}
