using System;

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
					
				}
				
				//Verificação de espaços
				
				//Juntar numeros
			}
			
			//Entregar resultado a usuario
			//Console.WriteLine(saida);
		}
		while (funcionando);
	}
}
