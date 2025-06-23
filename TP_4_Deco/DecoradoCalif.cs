/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 21/6/2025
 * Hora: 22:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using TP_4_Decorator;
using System.Linq;
namespace TP_4_Deco
{
	/// <summary>
	/// Description of DecoradoCalif.
	/// </summary>
	public class DecoradoCalif : AlumnoDecorator
	{
		public DecoradoCalif(IAlumnoDecorado decoprevio):base(decoprevio)
		{
		}
		
		public override string mostrarCalificacion()
		{
			return alumnoDecorado.mostrarCalificacion() +"  "+ (((IAlumnoDecorado)alumnoDecorado).getCalificacion()).ToString();
		}
	}
}
