/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 19:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
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
		
		
		public int responderPregunta(int pregunta)
		{
			return alumnoDecorado.responderPregunta(pregunta);
		}
		
		public virtual string getNombre()
		{
			return alumnoDecorado.getNombre();
		}
		
		public void Calificacion(int c)
		{
			alumnoDecorado.Calificacion(c);;
		}
		
		public bool sosIgual(IComparable comparable)
		{
			return alumnoDecorado.sosIgual(comparable);
		}
		
		public bool sosMenor(IComparable comparable)
		{
			return alumnoDecorado.sosMenor(comparable);;
		}
		
		public bool sosMayor(IComparable comparable)
		{
			return alumnoDecorado.sosMayor(comparable);
		} 
		
		public int getPromedio()
		{
			return alumnoDecorado.getPromedio();
		}
		
				
		public int getCalificacion()
		{
			return alumnoDecorado.getCalificacion();
		}
	}
}
