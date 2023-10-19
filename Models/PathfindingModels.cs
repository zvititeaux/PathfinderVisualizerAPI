namespace PathfinderVisualizerAPI.Models
{
    public class PathfindingModels
    {
        public int ID { get; set; } // Unique ID for the path
        public DateTime DateComputed { get; set; }
        public int[][] Grid { get; set; }
        public Node Start { get; set; }
        public Node End { get; set; }
        public string Algorithm { get; set; }
    }

    public class PathfindingResponse
    {
        public List<Node> Path { get; set; }
        public string Message { get; set; }
    }
    public class Node
    {
        public int Row { get; set; }
        public int Col { get; set; }
    }
}
