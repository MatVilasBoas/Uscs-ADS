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