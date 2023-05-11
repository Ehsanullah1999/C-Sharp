
using System;

class ShortestPath
{
    static void Main()
    {
        Console.Write("Enter the number of vertices: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // ساخت یک ماتریس برای نگهداری گراف
        int[,] graph = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                //صفر ساختن وزن بین دو یال
                graph[i, j] = 0;
            }
        }

        // دریافت اطلاعات گراف از کاربر
        Console.WriteLine("Enter edge information in the format (start end weight):");
        //حلقه‌ی نامحدود است که تا زمانی که رشته‌ای از ورودی خوانده می‌شود کار خود را انجام می‌دهد
        while (true) // و توسط یک شرط خروج از حلقه، یعنی ورود یک رشته خالی، پایان می‌یابد.
        {
            // تقسیم رشته‌ی ورودی به تکه‌های کوچکتر در هر جای خالی (فاصله) با استفاده از تابع Split() 
            string input = Console.ReadLine();
            if (input.Equals(""))
                break;
            string[] info = input.Split(); //رشته input فراخوانی میشود و در نتیجه در info قرار میگیرد
            int start = Convert.ToInt32(info[0]);
            int end = Convert.ToInt32(info[1]);
            int weight = Convert.ToInt32(info[2]);
            graph[start, end] = weight;
            graph[end, start] = weight; // گراف بدون جهت است، بنابراین هر یال بین دو رأس، دوستانه است
        }

        // دریافت دو رأس مبدا و مقصد از کاربر
        Console.Write("Enter the source vertex: ");
        int src = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the destination vertex: ");
        int dest = Convert.ToInt32(Console.ReadLine());

        // اجرای تابع دیکسترا برای پیدا کردن‌ کوتاه‌ترین مسیر بین دو رأس مبدا و مقصد
        Dijkstra(graph, src, dest);
        Console.ReadLine();
    }

    // تعریف تابع دیکسترا که برای پیدا کردن کوتاه ترین مسیر از آن استفاده می شود
    static void Dijkstra(int[,] graph, int src, int dest)
    {
        int n = graph.GetLength(0);
        int[] dist = new int[n]; // مجموع هزینه های طی شده از رأس شروع تا هر رأس
        bool[] visited = new bool[n]; // آیا رأس تا کنون در هنگام بررسی شده است
        int[] prev = new int[n]; // رأس قبلی در مسیر کوتاه ترین به هر رأس
        for (int i = 0; i < n; i++)
        {
            dist[i] = int.MaxValue; // هزینه های اولیه را برابر بی نهایت قرار دهید
            prev[i] = -1; // رأس قبلی برای هر رأس را برابر -1 قرار بدهید
            //مقدار اولیه‌ی آرایه prev را تعیین کند. 
        }
        dist[src] = 0; // هزینه راس آغازین را صقر قرار میدهیم

        // بررسی کردن هر رأس
        for (int i = 0; i < n - 1; i++)
        {
            // پیدا کردن رأس با کمترین هزینه از همه رئوس، که تا کنون بررسی نشده است
            int u = GetMinimumDistanceVertex(dist, visited);
            visited[u] = true;

            // بررسی همه رئوس مجاور رأس u و به‌روزرسانی هزینه ها
            for (int v = 0; v < n; v++)
                // یال های یو و وی را بررسی میکند که یال بین شان موجوداست یا خیر
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    prev[v] = u;
                }
            }
        }

        // چاپ کردن مسیر کوتاه ترین بین دو رأس
        Console.Write("The shortest path from " + src + " to " + dest + " is: ");
        PrintPath(prev, dest);
        Console.WriteLine(", with distance of " + dist[dest]);
    }

    // پیدا کردن رأس با کمترین هزینه از همه رئوس، که تا کنون بررسی نشده است
    static int GetMinimumDistanceVertex(int[] dist, bool[] visited)
    {
        int minDist = int.MaxValue;
        int minDistVertex = 0;
        for (int i = 0; i < dist.Length; i++)
        {
            if (!visited[i] && dist[i] <= minDist)
            {
                minDist = dist[i];
                minDistVertex = i;
            }
        }
        return minDistVertex;
    }

    // چاپ کردن مسیر کوتاه ترین بین دو رأس
    static void PrintPath(int[] prev, int v)
    {
        if (v < 0)
            return;
        PrintPath(prev, prev[v]);
        Console.Write(v + " ");
    }
}