using Telstar.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Telstar.Repository;
using Route = Telstar.Models.Route;

namespace Telstar.BusinessLogic;

public class RouteFindingAlgorithm
{
    private ConnectionRepository _connectionRepository = new ConnectionRepository();
    public List<InternalConnection> CalculateFastestRoute(String originCityName, String destinationCityName, bool recommendedShippingRequired)
    {
        return CalculateCheapestRoute(originCityName, destinationCityName, recommendedShippingRequired);
    }
    
    public List<InternalConnection> CalculateBestRoute(String originCityName, String destinationCityName, bool recommendedShippingRequired)
    {
        return CalculateCheapestRoute(originCityName, destinationCityName, recommendedShippingRequired);
    }

    public List<InternalConnection> CalculateCheapestRoute(String originCityName, String destinationCityName, bool recommendedShippingRequired)
    {
        return new List<InternalConnection>();
    }

    public ParcelRoute CalculateRoute(City origin, City destination)
    {
        var pathFinder = new PathFinder();
        var graph = new Graph(_connectionRepository.GetInternalConnections());
        var parcelRoute = pathFinder.ShortestPathFunction(graph, origin, destination);
        return parcelRoute;
    }
}

public class Graph {

    public Graph(IEnumerable<InternalConnection> connections) {
        foreach (var connection in connections)
        {
            AddEdge(connection, connection.FromCity);
            AddEdge(connection, connection.ToCity);
        }
    }

    public Dictionary<City, HashSet<InternalConnection>> AdjacencyList { get; } = new();

    public void AddEdge(InternalConnection connection, City city) {
        if (!AdjacencyList.ContainsKey(city)) AdjacencyList[city] = new HashSet<InternalConnection>();
        var newConnection = new InternalConnection();
        newConnection.FromCity = city;
        newConnection.ToCity = connection.FromCity.Equals(city) ? connection.ToCity : connection.FromCity;
        newConnection.Distance = connection.Distance;
        newConnection.Id = connection.Id;
        AdjacencyList[city].Add(newConnection);
    }
}

public class ParcelRoute : IComparable
{
    public List<InternalConnection> connections;
    public bool RecommendedShipping { get; set; } = false;

    public ParcelRoute(InternalConnection connection)
    {
        connections = new List<InternalConnection>();
        connections.Add(connection);
    }
    public ParcelRoute(List<InternalConnection> connections)
    {
        this.connections = connections;
    }

    public double GetTravelTime()
    {
        return connections.Sum(edge => edge.Distance * 4);
    }

    public double GetPrice()
    {
        return connections.Sum(edge => edge.Distance * 3) + (RecommendedShipping ? 10 : 0);
    }

    public double GetAPICallPrice()
    {
        return GetPrice() * 1.05f;
    }

    protected bool Equals(ParcelRoute other)
    {
        return connections.Equals(other.connections);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ParcelRoute)obj);
    }

    public override int GetHashCode()
    {
        return connections.GetHashCode();
    }

    public int CompareTo(object? obj)
    {
        return GetTravelTime().CompareTo(((obj as ParcelRoute)!).GetTravelTime());
    }

    public InternalConnection GetLast()
    {
        return connections[connections.Count - 1];
    }
}

class PathFinder
{
    public ParcelRoute ShortestPathFunction(Graph graph, City start, City target)
    {
        var queue = new PriorityQueue<ParcelRoute>();
        foreach (InternalConnection connection in graph.AdjacencyList[start])
        {
            queue.Enqueue(new ParcelRoute(connection));
        }

        int iterations = 0;
        while (queue.Count > 0 && iterations < 1000)
        {
            iterations += 1;
            var route = queue.Dequeue();
            if (route.GetLast().ToCity.Equals(target)) return route;
            
            foreach(var neighbor in graph.AdjacencyList[route.GetLast().ToCity])
            {
                var newRoute = new List<InternalConnection>(route.connections);
                newRoute.Add(neighbor);
                ParcelRoute newParcelRoute = new ParcelRoute(newRoute);
                if (neighbor.ToCity.Equals(target)) return newParcelRoute;
                queue.Enqueue(new ParcelRoute(newRoute));
            }
        }

        return null;
    }   
}

class PriorityQueue<T> where T : IComparable
{
    private List<T> list;
    public int Count { get { return list.Count; } }
    public readonly bool IsDescending;

    public PriorityQueue()
    {
        list = new List<T>();
    }

    public PriorityQueue(bool isdesc)
        : this()
    {
        IsDescending = isdesc;
    }

    public PriorityQueue(int capacity)
        : this(capacity, false)
    { }

    public PriorityQueue(IEnumerable<T> collection)
        : this(collection, false)
    { }

    public PriorityQueue(int capacity, bool isdesc)
    {
        list = new List<T>(capacity);
        IsDescending = isdesc;
    }

    public PriorityQueue(IEnumerable<T> collection, bool isdesc)
        : this()
    {
        IsDescending = isdesc;
        foreach (var item in collection)
            Enqueue(item);
    }


    public void Enqueue(T x)
    {
        list.Add(x);
        int i = Count - 1;

        while (i > 0)
        {
            int p = (i - 1) / 2;
            if ((IsDescending ? -1 : 1) * list[p].CompareTo(x) <= 0) break;

            list[i] = list[p];
            i = p;
        }

        if (Count > 0) list[i] = x;
    }

    public T Dequeue()
    {
        T target = Peek();
        T root = list[Count - 1];
        list.RemoveAt(Count - 1);

        int i = 0;
        while (i * 2 + 1 < Count)
        {
            int a = i * 2 + 1;
            int b = i * 2 + 2;
            int c = b < Count && (IsDescending ? -1 : 1) * list[b].CompareTo(list[a]) < 0 ? b : a;

            if ((IsDescending ? -1 : 1) * list[c].CompareTo(root) >= 0) break;
            list[i] = list[c];
            i = c;
        }

        if (Count > 0) list[i] = root;
        return target;
    }

    public T Peek()
    {
        if (Count == 0) throw new InvalidOperationException("Queue is empty.");
        return list[0];
    }

    public void Clear()
    {
        list.Clear();
    }
}

