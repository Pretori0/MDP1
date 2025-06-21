/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 19:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator :IAlumnoDecorado
	{
	 	public IAlumnoDecorado alumnoDecorado;
	 	public AlumnoDecorator(IAlumnoDecorado alumno)
		{
			this.alumnoDecorado = alumno;
		}
		
		public virtual string mostrarCalificacion(){
			return alumnoDecorado.mostrarCalificacion();
		}
		
	}
}
