using System.Collections.Generic;

namespace Graph
{
    public interface IGraph<T>
    {
        void AddVertex(T vertex, List<T> connectedvertices);
        void AddEdge(T vertex1, T vertex2);
    }
}