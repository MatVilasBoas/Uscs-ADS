package heranca;


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