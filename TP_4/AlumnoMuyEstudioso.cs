/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 00:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso:Alumno
	{
		public AlumnoMuyEstudioso(string n, int d, int l, int p):base(n, d,l,p)
		{
		}
		public override int responderPregunta(int pregunta){
			return pregunta%3;
		}
		
	}
}
