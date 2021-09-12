package aulas.oo.part01.paradigma.exemplo001;

import java.util.Scanner;

public class Pessoa {

    private String nome = "Glauber";
    private Integer age = 42;

    public String getNome() {
        return nome;
    }
    public Integer getAge() {return age;}

    public String falarMeuProprioNomeAndIdade(){
        return "Olá, meu nome é " + getNome() + ". Minha idade é " + getAge() + " anos.";
    }

    public String andar() {
        return "Estou andando...";
    }
}
