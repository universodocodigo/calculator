using System;
using System.Collections.Generic;

class Calculadora
{
	static void Main(string[] args)
	{
		bool funcionando = true;
		
		//Variaveis globais
		string numeros = "0123456789";
		string sinais = "+-*/";
		string espaco = " ";
		
		string grupoNumerico = "";
		
		List<string> valores = new List<string>();
		List<string> operacoes = new List<string>();
		
		do
		{
			//Receber a expressão do usuario
			Console.Write("Digite sua expressão: ");
			string entrada = Console.ReadLine();
			
			//Processamento da entrada
			for(int i = 0; i < entrada.Length; i++)
			{
				
				string valorDaEntrada = entrada[i].ToString();
				
				//Verificação de numeros
				if(numeros.Contains(valorDaEntrada))
				{
					grupoNumerico += valorDaEntrada;
				}
				
				//Verificação de sinais
				if(sinais.Contains(valorDaEntrada))
				{
					operacoes.Add(valorDaEntrada);
					valores.Add(grupoNumerico);
					grupoNumerico = "";
					
				}
				
				//Verificação de espaços
				if(espaco.Contains(valorDaEntrada))
				{
					continue;
				}
			}
			//Zerar grupo numerico
			valores.Add(grupoNumerico);
			
			//Entregar resultado a usuario
			Console.WriteLine(string.Join(", ", operacoes));
			Console.WriteLine(string.Join(", ", valores));
		}
		while (funcionando);
	}
}
