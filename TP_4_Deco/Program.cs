/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4_Decorator
{
	class Program
	{
		public static void Main(string[] args)
		{
			
						
			//TP_4_Decorator
			
			//Adapter{
			Teacher teacher = new Teacher();
			FabricaDeAlumnos fAlum=new FabricaDeAlumnos();
			GeneradorDeDatosAleatorios grand = new GeneradorDeDatosAleatorios();
            for(int i=0;i<10;i++){
				
				//IComparable alu= fAlum.crearComparable("a");
				IAlumnoDecorado alu = new Alumno(grand.stringAleatorio(6),grand.numeroAleatorio(49999999),grand.numeroAleatorio(99999),grand.numeroAleatorio(10));
				IAlumnoDecorado dec1 = new DecoradoLetras(alu);
				Student aAdaptado=new AlumnoAdapter(dec1);
				
            	teacher.goToClass(aAdaptado);
            	
            	//IComparable muyE=fAlum.crearComparable("aMuyE");
            	IAlumnoDecorado muyE = new AlumnoMuyEstudioso(grand.stringAleatorio(6),grand.numeroAleatorio(49999999),grand.numeroAleatorio(99999),grand.numeroAleatorio(10));
            	IAlumnoDecorado dec0 = new DecoradoLetras(muyE);
            	Student aMuyE=new AlumnoAdapter(dec0);
            	
            	teacher.goToClass(aMuyE);
            }
			
            teacher.teachingAClass();
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
            
			//}Adapter
			
			
			//Decorator{
			/*
			Teacher teacher = new Teacher();
			//FabricaDeAlumnos fAlum=new FabricaDeAlumnos();
			GeneradorDeDatosAleatorios grand = new GeneradorDeDatosAleatorios();
			
            for(int i=0;i<10;i++){
				
				IAlumnoDecorado alu= new Alumno(grand.stringAleatorio(6),grand.numeroAleatorio(49999999),grand.numeroAleatorio(99999) ,grand.numeroAleatorio(10));
				IAlumnoDecorado deco0=new DecoradoLetras(alu);
				Student alumnoAdapter=new AlumnoAdapter(deco0);
				

				teacher.goToClass(alumnoAdapter);
            	/*
				//IComparable muyE=fAlum.crearComparable("aMuyE");
				AlumnoMuyEstudioso aMuyE= new AlumnoMuyEstudioso(grand.stringAleatorio(6),grand.numeroAleatorio(49999999),grand.numeroAleatorio(99999) ,grand.numeroAleatorio(10));
				IAlumnoDecorado deco1=new DecoradoLetras(aMuyE);
            	AlumnoAdapter MuyE=new AlumnoAdapter((Alumno)deco1);
				
            	
            	teacher.goToClass((Student)MuyE); 
            	
            	
            }
			
            teacher.teachingAClass();
                 
			//}Decorator 
			*/
			
			
		}
		/*
		public static void llenar(IColeccionable coleccionable, int opcion)
        {
            for (int i = 0; i < 20; i++)
            {
            	IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccionable.agregar(comparable);
            }
        }
		
		public static void informar(IColeccionable coleccionable, int opcion)
        {
			
			Console.WriteLine(coleccionable.cuantos());
			Console.WriteLine(((IComparable)coleccionable.minimo()).ToString());
			Console.WriteLine(((IComparable)coleccionable.maximo()).ToString());
            						
            IComparable comparableAux = FabricaDeComparables.crearPorTeclado(opcion);
            
            if (coleccionable.contiene(comparableAux))
            {
                Console.WriteLine("El elemento esta en la coleccion");
            }
            else
            {
                Console.WriteLine("el elemento no esta en la coleccion");
            }*/
        }
	}
