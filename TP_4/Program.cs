/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			
						
			//TP_4
			
			//Adapter{
			Teacher teacher = new Teacher();
			FabricaDeAlumnos fAlum=new FabricaDeAlumnos();
            
            for(int i=0;i<10;i++){
				
				IComparable alu= fAlum.crearComparable("a");
				AlumnoAdapter aAdaptado=new AlumnoAdapter((Alumno)alu);
            	teacher.goToClass(aAdaptado);
            	IComparable muyE=fAlum.crearComparable("aMuyE");
            	AlumnoAdapter aMuyE=new AlumnoAdapter((Alumno)muyE);
            	teacher.goToClass(aMuyE);
            }
			
            teacher.teachingAClass();
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
            
			
		}
		
     }
 }
