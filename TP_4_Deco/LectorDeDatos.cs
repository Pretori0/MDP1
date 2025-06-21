/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 31/5/2025
 * Hora: 18:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado(){
			return int.Parse(Console.ReadLine());
			
		}
		
		public string stringPorTeclado(){
			return Console.ReadLine();
		}
		
		
	}
}
