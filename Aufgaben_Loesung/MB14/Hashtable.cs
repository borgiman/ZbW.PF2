namespace MB14;

public class Element
{
    public string Id;
    public string Name;

    public Element(string id, string name)
    {
        Id = id;
        Name = name;
    }
}

public class Hashtable
{
    private List<Element>[] table;

    public Hashtable(int groesse = 10)
    {
        table = new List<Element>[groesse];

        for (var i = 0; i < table.Length; i++)
        {
            table[i] = new List<Element>();
        }
    }

    /// <summary>
    /// Element in der Hashtabelle einfügen
    /// </summary>
    /// <param name="e">einzufügendes Element</param>
    /// <returns>
    /// true: Element wurde eingefügt;
    /// false: Hashtabelle voll; Element nicht eingefügt
    /// </returns>
    public bool Put(Element e)
    {
        var hash = e.Id.GetHashCode();
        if (hash < 0)
        {
            hash *= -1;
        }

        var index = hash % table.Length;
        var list = table[index];

        foreach (var item in list)
        {
            if (item.Id.Equals(e.Id))
            {
                return false;
            }
        }

        list.Add(e);
        return true;
    }

    /// <summary>
    /// Element in der Hashtabelle suchen
    /// </summary>
    /// <param name="id">Schlüssel des zu suchenden Elementes</param>
    /// <returns>
    /// gesuchtes Element; 
    /// null-> Element nicht gefunden
    /// </returns>
    public Element Get(string id)
    {
        var hash = id.GetHashCode();
        if (hash < 0)
        {
            hash *= -1;
        }

        var index = hash % table.Length;
        var list = table[index];

        foreach (var item in list)
        {
            if (item.Id.Equals(id))
            {
                return item;
            }
        }

        return null;
    }

    /// <summary>
    /// Element in der Hashtabelle löschen
    /// </summary>
    /// <param name="id">Schlüssel des zu löschenden Elementes</param>
    /// <returns>
    /// true: Element wurde gelöscht; 
    /// false: Element nicht gefunden
    /// </returns>
    public bool Delete(string id)
    {
        var hash = id.GetHashCode();
        if (hash < 0)
        {
            hash *= -1;
        }

        var index = hash % table.Length;
        var list = table[index];

        for (var i = 0; i < list.Count; i++)
        {
            var element = list[i];
            if (element.Id == id)
            {
                list.Remove(element);
                return true;
            }
        }

        return false;
    }
}