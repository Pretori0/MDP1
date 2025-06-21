/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 15:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of PorDni.
	/// </summary>
	public class PorDni : StrategyAlumno
	{
		public PorDni()
		{
		}
		
		public int comparar(Alumno alu, Alumno blu)
		{
			if(blu.getDni == alu.getDni){
				return 1;
			}
			if(blu.getDni < alu.getDni){

			return 2;
			}
			
			return 3;
		}
	}
}
