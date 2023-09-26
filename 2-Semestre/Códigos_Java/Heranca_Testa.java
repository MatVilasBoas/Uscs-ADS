package heranca;


public class testaheranca {

    public static void main(String[] args) {
        
        gerente x = new gerente(500, "Matheus", 2000, 123);

        funcionario[] set = new funcionario[3];
        set[0] = x;
        set[1] = new funcionario("Gabriel", 1000, 213);

        set[2] = new funcionario("Felipe", 1000, 321); 

        for (int i=0; i< set.length ; i++)

        System.out.println (set[i].getNome() + " " + set[i].getSalario());
    }
    
}