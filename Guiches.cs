using System.Collections.Generic;

public class Guiches
{
    private List<Guiche> listaGuiches;

    public Guiches()
    {
        listaGuiches = new List<Guiche>();
    }

    public void adicionar(Guiche guiche)
    {
        listaGuiches.Add(guiche);
    }

    public List<Guiche> getListaGuiches()
    {
        return listaGuiches;
    }

    public Guiche buscar(int id)
    {
        foreach (Guiche guiche in listaGuiches)
        {
            if (guiche.getId() == id)
            {
                return guiche;
            }
        }

        return null;
    }
}
