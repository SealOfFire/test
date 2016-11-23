namespace ConsoleApplication1
{
    public class Hello
    {
        public class Node
        {
            public int Value;
            public int sum;
            public int Level;
            public Node Parent;
            public Node Left;
            public Node Right;
            public string Text;

            public Node()
            {
            }

            public Node(int value)
            {
                this.Value = value;
                this.sum = value;
                // this.Text = "R";
            }

            public Node(Node parent, int value, int level)
            {
                this.Parent = parent;
                this.Value = value;
                this.Level = level;
                this.sum = parent.sum + value;
                if (value > 0)
                {
                    Text = parent.Text + "R";
                }
                else
                {
                    Text = parent.Text + "L";
                }
            }
        }

        public static void Main()
        {
            var line = System.Console.ReadLine();
            string[] temp = line.Split(' ');
            int length = int.Parse(temp[0]);
            int count = int.Parse(temp[1]);
            int[] intput = new int[count];

            System.Collections.Generic.List<Node> last = new System.Collections.Generic.List<Node>();
            last.Add(new Node());
            for (int i = 0; i < count; i++)
            {
                intput[i] = int.Parse(System.Console.ReadLine());

                System.Collections.Generic.List<Node> newLine = new System.Collections.Generic.List<Node>();

                foreach (Node n in last)
                {
                    Node left = new Node(n, 0 - intput[i], i);
                    Node right = new Node(n, intput[i], i);

                    if (System.Math.Abs(left.sum) <= length)
                    {
                        n.Left = left;
                        newLine.Add(left);
                    }

                    if (System.Math.Abs(right.sum) <= length)
                    {
                        n.Right = right;
                        newLine.Add(right);
                    }
                }

                last = newLine;
            }

            System.Console.WriteLine(last[0].Text);
        }
    }
}
