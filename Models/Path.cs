namespace PathfinderVisualizerAPI.Models
{
    public class PathModel
    {
        public int Id { get; set; }
        public string PathData { get; set; } 
        public string AlgorithmUsed { get; set; }
        public string StartingPoint { get; set; }
        public string EndingPoint { get; set;}
        public string Obstacles { get; set; }
        public string ResultingPath { get; set; }
    }
}
