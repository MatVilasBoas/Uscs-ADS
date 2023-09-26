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