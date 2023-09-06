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

///////////////////////////Classe Pilha////////////////////////////////


public class Pilha 
{
    //Atributos
    int dados[];
    int topo;
    int capacidade;
    
    //Construtor
    public Pilha (int c) 
    {
        capacidade = c;
        topo = -1;
        dados = new int [capacidade];
    }
    
    //Metódos
    public boolean empilha(int x)
    {
        if (!cheia())
        {
        topo++;
        dados[topo] = x;
        return true;
        }
        System.out.println("cheia");
        return false;
    }
    
    public void mostraAoContrario()
    {
        for ( int i = topo; i>=0; i--)
        System.out.println(dados[i]);
    }
    
    public boolean cheia()
    {
        return (topo==capacidade-1);
    }
    
    public boolean vazia()
    {
        return (topo==-1);
    }
    public int conta ()
    {
        return (topo +1);
    }
}