/*
 * Creado por SharpDevelop.
 * Usuario: bcn
 * Fecha: 31/5/2025
 * Hora: 18:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		
		public FabricaDeComparables()
		{
		}
		
		public static IComparable crearAleatorio(int opcion){

			FabricaDeComparables fabrica = null;
			if(opcion == 1){
				fabrica = new FabricaDeAlumnos();
			}
			/*
			if(opcion==2){
				fabrica=new FabricaDeNumeros();
			}
			if(opcion==3){
				fabrica=new FabricaDeProfesores();
			}*/
			return fabrica.crearComparable("a");
		}
		
		public static IComparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			if(opcion==1){
				fabrica = new FabricaDeAlumnos();
			}
			/*
			if(opcion==2){
				fabrica = new FabricaDeNumeros();
			}
			
			if(opcion==3){
				fabrica=new FabricaDeProfesores();
			}*/
				
			return fabrica.crearComparable("t");
		
		}
		
		public abstract IComparable crearComparable(string opcion);
		
	}
}
