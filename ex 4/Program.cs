Console.OutputEncoding = System.Text.Encoding.UTF8;

string s = "біологія, алгебра, історія, географія, геометрія";

string[] a = s.Split(' ');

string temp = a[0];
a[0] = a[1];
a[1] = temp;

string result = string.Join(" ", a);

Console.WriteLine(result);
Console.ReadKey();
