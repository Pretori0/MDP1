/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 12/4/2025
 * Hora: 17:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public abstract class Persona : IComparable
	{
		
		protected string nombre; protected int dni;
		
		public Persona ( string n, int d){
			this.nombre = n;
			this.dni = d;
		}
		
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDni {
			get {return this.dni;}
			
		}
		
		public virtual bool sosIgual(IComparable comparable){
			if( this.getDni == ((Persona)comparable).getDni){
				return true;
			}
			return false;
		}
		public virtual bool sosMenor(IComparable comparable){
			if (this.getDni > ((Persona)comparable).getDni){
				return true;
			}
			return false;
		}
		public virtual bool sosMayor(IComparable comparable){
			if(this.getDni < ((Persona)comparable).getDni){
				return true;
			}
			return false;
		}
		
		
 
		
	}
}
