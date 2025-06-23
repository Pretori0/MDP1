/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 26/4/2025
 * Hora: 00:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary>
	public class PorLegajo :StrategyAlumno
	{
		
		public PorLegajo()
		{
		}
		
		public int comparar(IAlumnoDecorado alu, IAlumnoDecorado blu)
		{
			if(((Alumno)blu).getLegajo == ((Alumno)alu).getLegajo){
				return 1;
			}
			if(((Alumno)blu).getLegajo < ((Alumno)alu).getLegajo){

			return 2;
			}
			
			return 3;
		}
	}
	
}

