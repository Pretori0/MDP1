/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 15:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of PorNombre.
	/// </summary>
	public class PorNombre : StrategyAlumno
	{
		public PorNombre()
		{
		}
		
		public int comparar(IAlumnoDecorado alu, IAlumnoDecorado blu)
		{
			if((blu.getNombre()).Length == (alu.getNombre()).Length){
				return 1;
			}
			if((blu.getNombre()).Length < (alu.getNombre()).Length){

			return 2;
			}
			
			return 3;
		}
	}
}
