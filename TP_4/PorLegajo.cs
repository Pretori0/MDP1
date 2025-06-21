/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 26/4/2025
 * Hora: 00:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo :StrategyAlumno
	{
		
		public PorLegajo()
		{
		}
		
		public int comparar(Alumno alu, Alumno blu)
		{
			if(blu.getLegajo == alu.getLegajo){
				return 1;
			}
			if(blu.getLegajo < alu.getLegajo){

			return 2;
			}
			
			return 3;
		}
	}
	
}

