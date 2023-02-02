// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Schema;


List<int> lss = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
void RecSubSeq(List<int> l, int idx)
{

}
var tl = new List<int>();
RecSubSeq(tl, 0);


LinkedList<int>[] lls = new LinkedList<int>[8];
//lls[0].AddLast(0);
int balancedForest(List<int> c, List<List<int>> edges)
{
    Dictionary<int, Node> nodes = new Dictionary<int, Node>();
    //ReadOnlySpan<int> dd = CollectionsMarshal.AsSpan(c);
    for (int i = 0; i < c.Count; i++)
    {
        nodes.Add(i, new Node() { Val = c[i], Idx = i });
    }
    for (int i = 0; i < edges.Count; i++)
    {
        nodes[edges[i][0] - 1].Children.AddLast(nodes[edges[i][1] - 1]);
        nodes[edges[i][1] - 1].Parent = nodes[edges[i][0] - 1];
        nodes[edges[i][1] - 1].OrigParent = nodes[edges[i][0] - 1];
    }
    List<int> sums = new List<int>();
    List<Node> disconnected_gphs = new List<Node>();
    List<Node> disconnected_node = new List<Node>();
    Action get_disconnect_graphs = null;
    Node rt = null;
    int id = 0;
    Action disconnect_graphs = () =>
    {
        //rememeber & reset the ealrier disconnected node - incase to fuse again
        var nn = rt.Children.ElementAt(id);
        if (nn == null)
        {

        }
        else
        {

        }
        nn.Parent = null;
        nn.Cnt++;
        //Disconnect the chain & Sequentually -> addpend & disconnect
        rt.Children.Remove(nn);
        rt = nn;
        get_disconnect_graphs();
    };

    Action sum_disconnected_graphs = () =>
    {
        sums = new List<int>();
        disconnected_gphs.ForEach(node =>
        {
            sums.Add(node.Sum());
        });
        if (sums.Distinct().Count() > 1)
        {
            //Reset the count
            sums.Clear();
            //disconnect the graph seq
            disconnect_graphs();
        }
    };
    
    get_disconnect_graphs = () =>
    {
        //List the disconnected graph
        disconnected_gphs = new List<Node>();
        nodes.Values.ToList().ForEach(t =>
        {
            if (t.Parent == null)
                disconnected_gphs.Add(t);
        });

        if (disconnected_gphs.Count() == 1)
        {
            disconnect_graphs();
        }
        else if (disconnected_gphs.Count() == 0)
        {
            Console.WriteLine("Looks like empty graph..");
        }
        else
        {
            sum_disconnected_graphs();
        }
    };
    
    //rt = nodes.ElementAt(0).Value;
    get_disconnect_graphs();
    return 2;
}
//balancedForest(new List<int>() { 1, 2, 2, 1, 1 }, new List<List<int>>() { new List<int>() { 1, 2 }, new List<int>() { 1, 3 }, new List<int>() { 3, 5 }, new List<int>() { 1, 4 } });
Console.WriteLine("Hello, World!");

List<int> hhs = new List<int>();
List<char> alphs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().ToList();
var dict = Enumerable.Zip(alphs, hhs, (f, s) =>
{
    return new KeyValuePair<char, int>(f, s);
}).ToDictionary(x => x.Key, x => x.Value);
int maxh = 0;
"".ToUpper().ToCharArray().ToList().ForEach(t =>
{
    maxh = dict[t] > maxh ? dict[t] : maxh;
});
var tt = maxh * "".Length;

List<int> lk = new List<int>();
int l1 = 0, l2 = 0;
string[] aa = new string[] { "5", "2", "C", "D", "+" };
for (int id = 0; id < aa.Length; id++)
{
    if (aa[id] == "+")
    {
        l2 = l1 + l2;
        lk.Add(l2);
    }
    else if (aa[id] == "D")
    {
        lk.Add(l1 + l2);
    }
}

float dd = 100.44f;
int dd1 = (int)dd;
Console.WriteLine(dd1);
object ddd = 0;
dd1 = (int)ddd;

Hashtable ht = new Hashtable();
SortedList<string, object> list = new SortedList<string, object>();
Queue<object> queue = new Queue<object>();
ht[ht.Count - 1] = ddd;
var ttd = ht[""];

object ddd2 = 0;
II ii = ddd2 as II;
string fff = "";
var iit = 0;
List<char> seq = new List<char>();
string s = "";
Stack left = new Stack();
foreach (char c in s.ToCharArray())
{
    if (c == '(' || c == '{' || c == '[')
    {
        left.Push(c); // Get left
    }
    // Compare to right:
    else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
    {
        left.Pop();
    }
    else if (c == '}' && left.Count != 0 && (char)left.Peek() == '{')
    {
        left.Pop();
    }
    else if (c == ']' && left.Count != 0 && (char)left.Peek() == '[')
    {
        left.Pop();
    }
    else
    {
        //return false; // no match
    }
}
//return true;
interface II
{

}



class TT
{
    void TTT<T>(T t) where T : TT, new()
    {

    }
    void kk()
    {
        var tt = Assembly.GetAssembly(typeof(TT));
        this.GetType();
        var ttt = Assembly.GetExecutingAssembly();
        //Assembly.Load()
    }
}

class Node
{
    public long Idx { get; set; }
    public int Val { get; set; }
    public int Cnt { get; set; }
    public Node Parent { get; set; }
    public Node OrigParent { get; set; }
    public int Sum()
    {
        return Children.Sum(t => t.Val);
    }
    public LinkedList<Node> Children { get; } = new LinkedList<Node>();
}