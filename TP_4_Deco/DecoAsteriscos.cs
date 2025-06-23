/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 22/6/2025
 * Hora: 15:51
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using TP_4_Decorator;
using System.Linq;
namespace TP_4_Deco
{
	/// <summary>
	/// Description of DecoAsteriscos.
	/// </summary>
	public class DecoAsteriscos : AlumnoDecorator 
	{
		
		public DecoAsteriscos(IAlumnoDecorado decoprevio):base(decoprevio)
		{
		}
		
		public override string mostrarCalificacion()
		{
			
			return  "***"+String.Concat(Enumerable.Repeat("*",(base.mostrarCalificacion().Length)))+"*\n" +"* " +base.mostrarCalificacion()+" *\n****"+String.Concat(Enumerable.Repeat("*",(base.mostrarCalificacion().Length)));
		}
		
	}
}
