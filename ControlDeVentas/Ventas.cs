using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeVentas
{
	internal class Ventas
	{
		private string _Producto;
		private int _Cantidad;

		public string Producto
		{
			get { return _Producto; }
			set { _Producto = value; }
		}
		public int Cantidad
		{
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

		//Asignacion de precio de los productos
		public double AsignacionPrecio()
		{
			switch (Producto)
			{
				case "Teclado": return 35;
				case "Impresora": return 350;
				case "Monitor": return 550;
				case "Bocinas": return 50;
				case "Mouse": return 20;
			}
			return 0;
		}

		//Calcular subtotal
		public double CalcularSubtotal()
		{
			return AsignacionPrecio() * Cantidad;
		}

		//Calcular Descuento
		public double CalcularDescuento()
		{
			double subTotal = CalcularSubtotal();

			if (subTotal >= 300) return 5.0 / 100 * subTotal;
			else if (subTotal > 300 && subTotal <= 500) return 10.0 / 100 * subTotal;
			else return 12.5 / 100 * subTotal;
		}

		//Calcular valor neto
		public double CalcularNeto()
		{
			return CalcularSubtotal() - CalcularDescuento();
		}

	}
}
