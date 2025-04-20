using MB15.SortComparison;

namespace MB15;

static class Program
{
    // Original from here:
    // https://www.codeproject.com/Articles/1087568/Visualization-and-Comparison-of-sorting-algorith
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmMain());
    }
}