public class Pessoa {
    private String nome;
    private int idade;
    private String email;
    
    public Pessoa(String nome, int idade, String email){
        this.nome = nome;
        this.idade = idade;
        this.email = email;
    }   
    
    public void imprime ()
    {
        System.out.println(nome);
        System.out.println(idade);
        System.out.println(email);
    }
}

//////////////////////////////classe testapessoa.java/////////////////////////////////

public class TestaPessoa{

    public static void main(String[] args) {
        Pessoa p1 = new Pessoa("matheus",19,"matheus@uol.com");
            
        System.out.println("Dados da 1° pessoa:");
        p1.imprime();

        Pessoa p2 = new Pessoa("Pedro",18,"pedro@pedro.com");
        
        System.out.println("Dados da 2° pessoa:");
        p2.imprime();

    }

}