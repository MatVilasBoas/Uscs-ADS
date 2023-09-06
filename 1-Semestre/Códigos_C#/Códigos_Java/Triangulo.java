public class Main
{
	public static void main(String[] args) {
		
	  // Criar um triangulo (construtor)
	  Triangulo x = new Triangulo (7,7,7); //
		
	  if (x.formaTriangulo () ==0) {
	    System.out.println ("Os valores não formam um triangulo");
	  }
	  else {
	    System.out.println ("Os valores  formam um triangulo");  
	  }
	 x.mostraTipo();
	 System.out.println("O perímetro é: " + x.perimetro());
	}
}

////////////////////////////////classe triangulo.java//////////////////////////////////////

public class Triangulo  
{
    
    // Atributos
    int ladoa;
    int ladob;
    int ladoc;
    
    // Construtores
    public Triangulo (int a, int b, int c) {
        ladoa = a;
        ladob = b;
        ladoc = c;
    }
    
    // Métodos = Funcionalidades
    public int formaTriangulo () 
    {
        
        int aux = 0; // nao eh um triangulo
    
        // maior que o valor absoluto (módulo) da diferença dos outros dois lados e 
        if ( ladoa > diferenca(ladob,ladoc) &&
             ladob > diferenca(ladoa,ladoc) &&
             ladoc > diferenca(ladoa,ladob) &&
        // menor que a soma dos outros dois lados
             ladoa < ladob + ladoc &&
             ladob < ladoa + ladoc &&
             ladoc < ladoa + ladob
          )
          aux = 1; // eh um triangulo
    
        return aux;
    }
    
    public void mostraTipo() 
    {
      // Equilatero (3 lados sao iguais)
      // Isosceles  (2 lados sao iguais e um diferente)
      // Escaleno   (3 lados sao diferentes)
      
     if (ladoa==ladob && ladoa == ladoc) System.out.println("Equilatero");
     else if (ladoa != ladob && ladoa != ladoc && ladob != ladoc ) 
          {
            System.out.println("Escaleno");
          }
          else System.out.println("Isosceles");
    }
    
    private int diferenca (int a, int b) 
    {
        int aux;
        aux = b-a;
        if (aux < 0) aux = aux * (-1);
        return aux;  
    }
    public int perimetro(){
        return ladoa + ladob + ladoc;
    }
}