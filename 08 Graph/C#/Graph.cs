using System.Collections.Generic;
using System.Linq;

namespace Graph
{
    public class Graph<T> : IGraph<T>
    {
        Dictionary<T, List<T>> _adjacencyMatrix;

        public Graph()
        {
            _adjacencyMatrix = new Dictionary<T, List<T>>();
        }

        void IGraph<T>.AddEdge(T vertex1, T vertex2)
        {
            List<T> connectedvertices;
            if (_adjacencyMatrix.TryGetValue(vertex1, out connectedvertices))
            {
                connectedvertices.Add(vertex2);
            }
            else
            {
                if (connectedvertices == null)
                {
                    connectedvertices = new List<T>();
                }
                connectedvertices.Add(vertex2);
                _adjacencyMatrix.Add(vertex1, connectedvertices);
            }
        }

        /// <summary>
        /// Find vertices U and V where the order is always U and V.
        /// </summary>
        /// <returns>returns the ordered vertices list</returns>
        public List<T> TropologicalSort()
        {
            Stack<T> sorted = new Stack<T>();
            Dictionary<T, bool> keyValues = new Dictionary<T, bool>();
            bool[] visited = new bool[_adjacencyMatrix.Keys.Count];

            for (int i = 0; i < _adjacencyMatrix.Keys.Count; i++)
            {
                var vertex = _adjacencyMatrix.Keys.ToArray()[i];
                TropologicalSort(vertex, keyValues, sorted);
            }

            sorted.Reverse();
            return sorted.ToList();
        }

        private void TropologicalSort(T i, Dictionary<T, bool> visited, Stack<T> sorted)
        {
            if (visited.ContainsKey(i)) //already visited
            {
                return;
            }

            visited.Add(i, true);
            sorted.Push(i);
            List<T> connectedVer;
            _adjacencyMatrix.TryGetValue(i, out connectedVer);
            if (connectedVer == null)   // no out going edge
            {
                return;
            }

            foreach (var connectedVertex in connectedVer)
            {
                bool hasVisited;
                visited.TryGetValue(connectedVertex, out hasVisited);
                if (!hasVisited)
                {
                    TropologicalSort(connectedVertex, visited, sorted);
                }
            }
        }

        void IGraph<T>.AddVertex(T vertex, List<T> connectedvertices)
        {
            _adjacencyMatrix.Add(vertex, connectedvertices);
        }
    }
}
