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