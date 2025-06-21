/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 4/6/2025
 * Hora: 01:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{
		GeneradorDeDatosAleatorios dran = new GeneradorDeDatosAleatorios();
		public FabricaDeAlumnos()
		{
		}
		
		public override IComparable crearComparable(string opcion)
		{
			Alumno alu = null;
			LectorDeDatos leer=new LectorDeDatos();
			if(opcion == "a"){
			alu=new Alumno(dran.stringAleatorio(5),dran.numeroAleatorio(75000000),dran.numeroAleatorio(99999),dran.numeroAleatorio(9));
			return alu;
			}
			
			if(opcion == "aMuyE"){
				alu=new AlumnoMuyEstudioso(dran.stringAleatorio(5),dran.numeroAleatorio(75000000),dran.numeroAleatorio(99999),dran.numeroAleatorio(9));
				return alu;
			}
			
			if(opcion=="t"){
				Console.WriteLine("Ingrese Nombre del Alumno:");
				string name=leer.stringPorTeclado();
				Console.WriteLine("Ingrese dni del Alumno:");	
				int d=leer.numeroPorTeclado();
				Console.WriteLine("Ingrese Legajo del Alumno:");
				int l=leer.numeroPorTeclado();
				Console.WriteLine("Ingrese promedio del Alumno:");
				int p=leer.numeroPorTeclado();
				return new Alumno(name,d,l,p);
			}
			
			return alu;
		}
		
		
	}
}
