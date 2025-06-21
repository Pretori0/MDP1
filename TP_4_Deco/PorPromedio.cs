/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 26/4/2025
 * Hora: 17:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary>
	public class PorPromedio : StrategyAlumno
	{
		public PorPromedio()
			
		{
		}
		
		public int comparar(IAlumnoDecorado alu, IAlumnoDecorado blu)
		{
			if(((Alumno)blu).getPromedio == ((Alumno)alu).getPromedio){
				return 1;
			}
			if(((Alumno)blu).getPromedio < ((Alumno)alu).getPromedio){

			return 2;
			}
			
			return 3;
			}
		}
	}

