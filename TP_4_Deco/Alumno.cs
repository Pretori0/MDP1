/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 9/4/2025
 * Hora: 20:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP_4_Decorator
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona,IAlumnoDecorado,IComparable
	{
		int legajo;
		int promedio;
		StrategyAlumno estrategia;
		Random rand;
		int calificacion;		
		public Alumno(string n, int d, int l, int p):base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
			this.estrategia = new PorPromedio();
			this.rand = new Random();
			this.calificacion = 4;
		}
		
						
		public int getLegajo{
			get{return this.legajo;}
		
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		
		public int Calif{
			get{return this.calificacion;}
			set{this.calificacion=value;}
		}
		
		public void Calificacion(int c){
			this.calificacion = c;
		}
		public int getCalificacion(){
			return this.Calif;
		}
		
		public override bool sosIgual(IComparable comparable){
			int resultado =  estrategia.comparar(this, (IAlumnoDecorado)comparable);
			if(resultado == 1){return true;}
			return false;
			
		}
		public override bool sosMenor(IComparable comparable){
			int resultado =  estrategia.comparar(this,(IAlumnoDecorado)comparable);
			if(resultado == 2){return true;}
			return false;
		}
		public override bool sosMayor(IComparable comparable){
			int resultado =  estrategia.comparar(this,(IAlumnoDecorado)comparable);
			if(resultado == 3){return true;}
			return false;

		}
		/*
		public override string ToString()
		{
			return string.Format("[Alumno {3} Dni {4} Legajo={0}, Promedio={1}, Estrategia={2}]", legajo, promedio, estrategia,nombre,dni);
		}

		*/
				
		public StrategyAlumno Estrategia{
			set{estrategia = value;}
		}

		public void prestarAtencion(){
			Console.WriteLine("{0} Prestando Atención",this.getNombre());
		}
		
		public void distraerse(){
			
			switch (this.rand.Next(0,2)){
					case 0:Console.WriteLine("{0} Dibujando",this.getNombre());break;
					case 1:Console.WriteLine("{0} Mirando el celular",this.getNombre());break;
					case 2:Console.WriteLine("{0} Tirando avioncitos",this.getNombre());break;
			}
		}
		
				
		public void actualizar(int opcion)
		{
			switch (opcion){
					case 1:this.prestarAtencion();break;
					case 2:this.distraerse();break;
			}
		}
		
		public virtual int responderPregunta(int pregunta){
			return this.rand.Next(1,3);
		}
		
		public string mostrarCalificacion(){
			return this.getNombre()+"   "+(this.getLegajo).ToString()+" ";
		}
		
	}
		
		
}

