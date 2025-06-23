/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 22/6/2025
 * Hora: 13:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using TP_4_Decorator;

namespace TP_4_Deco
{
	/// <summary>
	/// Description of DecoPAD.
	/// </summary>
	public class DecoPAD:AlumnoDecorator
{
		
		public DecoPAD(IAlumnoDecorado decoprevio):base(decoprevio)
		{
			
		}
		
		public string spad(){
			if (this.getCalificacion() >= 7){
				return "(PROMOCION)";
			}
			if( this.getCalificacion() >= 4 && this.getCalificacion()<= 6 ){
				return "(APROBADO)";
			}
			return "(DESAPROBADO)";
		}
		
		public override string mostrarCalificacion()
		{
			return base.mostrarCalificacion()+" "+this.spad();
		}
	}
}
