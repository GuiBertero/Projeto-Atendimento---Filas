using System.Collections.Generic;

public class Guiche
{
    private int id;
    private Queue<Senha> atendimentos;

    public Guiche()
    {
        atendimentos = new Queue<Senha>();
        id = 0;
    }

    public Guiche(int id)
    {
        atendimentos = new Queue<Senha>();
        this.id = id;
    }

    public int getId()
    {
        return id;
    }

    public Queue<Senha> getAtendimentos()
    {
        return atendimentos;
    }

    public bool chamar(Queue<Senha> filaSenhas)
    {
        if (filaSenhas.Count == 0)
        {
            return false;
        }

        Senha senha = filaSenhas.Dequeue();

        senha.atender();

        atendimentos.Enqueue(senha);

        return true;
    }
}
