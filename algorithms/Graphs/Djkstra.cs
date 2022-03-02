namespace Graphs
{

    public static class Dijkstra
    {


        public class DijkstraGraph
        {
            public string[] nodes;
            public uint[] edges;
        }
        public class DijkstraAlgorithmData
        {
            public DijkstraGraph graph;
            public uint[] open_list;
            public uint open_list_size;
            public uint[] node_cost;
            public uint[] prev_node;
            public uint starting_node;
            public uint ending_node;
        }

        /// <summary>
        ///  Nodes: list of nodes names;
        ///  edges: a array whene every 3 elments constructs an edge.
        ///  first element is starting node index, second is ending node index, third is movement cost (non zero) non negative.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="edges"></param>
        /// <returns></returns>
        public static DijkstraGraph SetupGrid(string[] nodes, uint[] edges)
        {
            DijkstraGraph dg = new();
            dg.nodes = nodes;
            dg.edges = edges;
            return dg;
        }


        public static DijkstraAlgorithmData StartDijkstra(DijkstraGraph graph, uint starting_node, uint ending_node)
        {
            var data = new DijkstraAlgorithmData();
            data.graph = graph;
            data.starting_node = starting_node;
            data.ending_node = ending_node;


            data.node_cost = new uint[graph.nodes.Length];
            data.prev_node = new uint[graph.nodes.Length];

            for (int i = 0; i < graph.nodes.Length; ++i)
            {
                data.node_cost[i] = uint.MaxValue;
                data.prev_node[i] = uint.MaxValue;
            }
            data.node_cost[starting_node] = 0;
            data.open_list = new uint[graph.nodes.Length];
            data.open_list[0] = starting_node;
            data.open_list_size = 1;

            return data;
        }


        public static uint[] GetPath(DijkstraAlgorithmData data)
        {
            uint count_walker = data.prev_node[data.ending_node];
            int count = 0;

            while (count_walker != uint.MaxValue)
            {
                count += 1;
                count_walker = data.prev_node[count_walker];
            }

            if (count == 0)
            {
                return null;
            }
            else
            {
                var ret = new uint[count];
                var path_walker = data.ending_node;

                while (path_walker != data.starting_node)
                {
                    ret[count - 1] = path_walker;
                    path_walker = data.prev_node[path_walker];
                }

                return ret;
            }
        }
        public static bool Process(DijkstraAlgorithmData data)
        {

            //check what is connected to the starting node
            //add them to the open list.

            for (int i = 0; i < data.graph.edges.Length; i += 3)
            {
                var node = data.open_list[data.open_list_size - 1];
                data.open_list_size -= 1;
                uint edge_start = data.graph.edges[i];
                uint edge_end = data.graph.edges[i + 1];
                uint cost = data.graph.edges[i + 2];

                if (edge_end == node)
                {
                    var v = edge_start;
                    edge_start = edge_end;
                    edge_end = v;
                }

                if (edge_start == node)
                {
                    if (data.node_cost[edge_end] > data.node_cost[node] + cost)
                    {
                        data.node_cost[edge_end] = data.node_cost[node] + cost;
                        data.prev_node[edge_end] = node;

                        data.open_list[data.open_list_size] = edge_end;
                        data.open_list_size += 1;
                    }
                }
            }

            if (data.open_list_size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}