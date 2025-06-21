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
	/// Description of PorDni.
	/// </summary>
	public class PorDni : StrategyAlumno
	{
		public PorDni()
		{
		}
		
		public int comparar(IAlumnoDecorado alu, IAlumnoDecorado blu)
		{
			if(((Alumno)blu).getDni == ((Alumno)alu).getDni){
				return 1;
			}
			if(((Alumno)blu).getDni < ((Alumno)alu).getDni){

			return 2;
			}
			
			return 3;
		}
	}
}
