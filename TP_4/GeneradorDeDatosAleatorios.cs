/*
 * Creado por SharpDevelop.
 * Usuario: Edgar
 * Fecha: 7/5/2025
 * Hora: 12:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_4
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		Random rnd = new Random();
		
		
		public GeneradorDeDatosAleatorios()
		{
			
		}
		
		public int numeroAleatorio(int max){
		
		return rnd.Next(max);
		}
		
		public string stringAleatorio(int cant){
		 
		string cadenaAux = "abcdefghijklmnñopqrstuvwxyz";
		
		string cadena = null;
		for(int i=0;i<cant;i++){
			cadena = cadena + cadenaAux[rnd.Next(26)];
		}
		return cadena;
			
		
		}
		
		
	}
}
