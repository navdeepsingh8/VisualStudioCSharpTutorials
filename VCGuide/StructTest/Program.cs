public struct CoOrds
{
    public int x, y;
    private System.Collections.ArrayList al;

    public CoOrds(int p1, int p2)
    {
        x = p1;
        y = p2;
        al = new System.Collections.ArrayList(2);
        al.Add(x);
        al.Add(y);
    }
}

public class TestCoOrds
{
    static void Main()
    {
        CoOrds c = new CoOrds(1, 2);
        
        CoOrds c2;
        c2.x = 2;
        //c2.y = 3;

        System.Console.WriteLine(c.GetType());
        System.Console.WriteLine(c2.x);
        System.Console.ReadLine();

    }

}

