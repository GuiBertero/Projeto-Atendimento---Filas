using System;

public class Senha
{
    private int id;
    private DateTime dataGerac;
    private DateTime horaGerac;
    private DateTime dataAtend;
    private DateTime horaAtend;

    public Senha(int id)
    {
        this.id = id;
        this.dataGerac = DateTime.Now.Date;
        this.horaGerac = DateTime.Now;
        this.dataAtend = DateTime.MinValue;
        this.horaAtend = DateTime.MinValue;
    }

    public int getId()
    {
        return id;
    }

    public DateTime getDataGerac()
    {
        return dataGerac;
    }

    public DateTime getHoraGerac()
    {
        return horaGerac;
    }

    public DateTime getDataAtend()
    {
        return dataAtend;
    }

    public DateTime getHoraAtend()
    {
        return horaAtend;
    }

    public void atender()
    {
        dataAtend = DateTime.Now.Date;
        horaAtend = DateTime.Now;
    }

    public string dadosParciais()
    {
        return id + "-" +
               dataGerac.ToString("dd/MM/yyyy") + "-" +
               horaGerac.ToString("HH:mm:ss");
    }

    public string dadosCompletos()
    {
        return id + "-" +
               dataGerac.ToString("dd/MM/yyyy") + "-" +
               horaGerac.ToString("HH:mm:ss") + "-" +
               dataAtend.ToString("dd/MM/yyyy") + "-" +
               horaAtend.ToString("HH:mm:ss");
    }
}
