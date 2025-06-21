/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 15/6/2025
 * Hora: 19:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of DecoradoLetras.
	/// </summary>
	public class DecoradoLetras:AlumnoDecorator
	{
		
		List <string> numeros;
		
		
		public DecoradoLetras(IAlumnoDecorado decoprevio):base(decoprevio)
		{
			numeros = new List<string>();
			this.numeros.Add("cero");
			this.numeros.Add("uno");
			this.numeros.Add("dos");
			this.numeros.Add("tres");
		    this.numeros.Add("cuatro");
			this.numeros.Add("cinco");
			this.numeros.Add("seis");
			this.numeros.Add("siete");
			this.numeros.Add("ocho");
			this.numeros.Add("nueve");
			this.numeros.Add("diez");
		}
		
		public override string mostrarCalificacion(){
			
			return alumnoDecorado.mostrarCalificacion()+"   "+numeros[((Alumno)alumnoDecorado).getCalificacion];
		}
	}
}
