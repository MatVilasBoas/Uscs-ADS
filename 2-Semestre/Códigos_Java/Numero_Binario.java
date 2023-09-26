public class Main
{
	public static void main(String[] args) {
		
		Pilha p = new Pilha (100);
		
		int n = 50, resto;
		
		while (n != 0) 
		{
		    resto = n % 2;
		    p.empilha (resto);
		    n = n / 2;
		}
		
		p.mostraAoContrario();
		System.out.println("A pilha tem: " + p.conta() + " elementos");
	}
}