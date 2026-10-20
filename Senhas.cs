using System.Collections.Generic;

public class Senhas
{
    private int proximoAtendimento;
    private Queue<Senha> filaSenhas;

    public Senhas()
    {
        filaSenhas = new Queue<Senha>();
        proximoAtendimento = 1;
    }

    public void gerar()
    {
        Senha senha = new Senha(proximoAtendimento);

        filaSenhas.Enqueue(senha);

        proximoAtendimento++;
    }

    public Queue<Senha> getFilaSenhas()
    {
        return filaSenhas;
    }
}
