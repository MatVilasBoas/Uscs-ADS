package herancafuncionario;


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

//////////////////////////classe funcionário.java////////////////////////////////

package herancafuncionario;


public class funcionario {
    
    public String nome;
    public double salario;
    public int codfunc;
    double getsalario;
    
    public funcionario(){}

    public funcionario(String nome, double salario, int codfunc) {
        this.nome = nome;
        this.salario = salario;
        this.codfunc = codfunc;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
    
    public void setSalario(double salario) {
        this.salario = salario;
    }
    
    public double getSalario() {
        return salario;
    }

    public int getCodfunc() {
        return codfunc;
    }

    public void setCodfunc(int codfunc) {
        this.codfunc = codfunc;
    }
    
}

///////////////////////////////classe gerente.java////////////////////////////////

package herancafuncionario;


public class gerente extends funcionario{
    
    public double bonus;
    
    public gerente(){}

    public gerente(double bonus, String nome, double salario, int codfunc) {
        super(nome, salario, codfunc);
        this.bonus = bonus;
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        this.bonus = bonus;
    }
    
    @Override
    public double getSalario(){
        return (super.getSalario() + this.bonus);
    }
} 