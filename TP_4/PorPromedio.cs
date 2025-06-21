/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio : StrategyAlumno
	{
		public PorPromedio()
			
		{
		}
		
		public int comparar(Alumno alu, Alumno blu)
		{
			if(blu.getPromedio == alu.getPromedio){
				return 1;
			}
			if(blu.getPromedio < alu.getPromedio){

			return 2;
			}
			
			return 3;
			}
		}
	}

