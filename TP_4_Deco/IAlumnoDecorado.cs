/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 19:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of IAlumnoDecorado.
	/// </summary>
	public interface IAlumnoDecorado:IComparable
		
	{
		string mostrarCalificacion();
		int responderPregunta(int pregunta);
		string getNombre();
		 void Calificacion(int c);
		 bool sosIgual(IComparable comparable);
		 bool sosMenor(IComparable comparable);
		 bool sosMayor(IComparable comparable);
	}
}
