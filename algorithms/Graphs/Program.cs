int[,] graph = new int[7, 7]{
 {0,0,0,0,0,0,0},
 {0,0,1,1,0,0,0},
 {0,1,0,0,1,0,0},
 {0,1,0,0,1,0,0},
 {0,0,1,1,0,1,1},
 {0,0,0,0,1,0,0},
 {0,0,0,0,1,0,0}};


bfs(graph, 5, 7);
DFS.Dfs(graph, 5, 7);

void bfs(int[,] arr, int start, int n)
{
    int i = start;
    Queue<int> q = new();
    int[] visited = new int[n];

    Console.WriteLine(i + " ");
    visited[i] = 1;
    q.Enqueue(i);

    while (q.Count > 0)
    {
        i = q.Dequeue();
        for (int j = 1; j < n; j++)
        {
            if (arr[i, j] == 1 && visited[j] == 0)
            {
                Console.WriteLine(j + "  ");
                visited[j] = 1;
                q.Enqueue(j);
            }
        }
    }
}
public static class DFS
{
    static int[] visited = new int[7];

    public static void Dfs(int[,] graph, int vertex, int n)
    {
        if (visited[vertex] == 0)
        {
            Console.Write(vertex + " ");
            visited[vertex] = 1;
            for (int j = 1; j < n; j++)
            {
                if (graph[vertex, j] == 1 && visited[j] == 0)
                {
                    Dfs(graph, j, n);
                }
            }

        }
    }
}