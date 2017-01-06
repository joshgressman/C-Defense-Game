namespace TreehouseDefense
{
  class Path
  {
    //Encapulates the MapLocation with a private array HIDES the array of MapLocations Private restricts access
    private readonly MapLocation[] _path;
    
    public int Length => _path.Length;
    
    //Path Constructor
    public Path(MapLocation[] path)
    {
      _path = path;
    }
    
    public MapLocation GetLocationAt(int pathStep)
    {
       return (pathStep < _path.Length) ? _path[pathStep] : null ; 
    }
  }
}