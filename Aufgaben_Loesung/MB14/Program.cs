namespace MB14;

public static class Program
{
    static void Main(string[] args)
    {
        var hashtable = new Hashtable();

        hashtable.Put(new Element("117", "Polizei"));
        hashtable.Put(new Element("118", "Feuerwehr"));

        var feuerwehrGeloescht = hashtable.Delete("118");
        if (!feuerwehrGeloescht)
        {
            throw new Exception("Fehler im Code");
        }

        feuerwehrGeloescht = hashtable.Delete("118");
        if (feuerwehrGeloescht)
        {
            throw new Exception("Fehler im Code");
        }

        var polizei = hashtable.Get("117");
        if (polizei.Name != "Polizei")
        {
            throw new Exception("Fehler im Code");
        }

        var unbekannt = hashtable.Get("unbekannt");
        if (unbekannt != null)
        {
            throw new Exception("Fehler im Code");
        }
    }
}