package heranca;


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