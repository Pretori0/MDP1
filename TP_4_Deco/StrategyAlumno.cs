/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 23/4/2025
 * Hora: 23:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of StrategyAlumno.
	/// </summary>
	public interface StrategyAlumno
	{
		 int comparar(IAlumnoDecorado alu, IAlumnoDecorado blu);
		
		
	}
}
