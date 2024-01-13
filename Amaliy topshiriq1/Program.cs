Console.Write("N sonini kiriting: ");
int N = Convert.ToInt32(Console.ReadLine());

int birliklar_xonasi = N % 10;
int onliklar_xonasi = (N / 10) % 10;
int yuzliklar_xonasi = (N / 100) % 10;
int mingliklar_xonasi = N / 1000;

Console.WriteLine(mingliklar_xonasi * yuzliklar_xonasi * onliklar_xonasi * birliklar_xonasi);