namespace TreehouseDefense
{
  class Invader
  {
   
    private readonly Path _path;
    
    private int _pathStep = 0;
    
    public MapLocation Location => _path.GetLocationAt(_pathStep);
    
    public int Health {get; private set;} = 2; //propert with getter and setter
    
    //true if the invader reaches the end of the path;
    public bool HasScored {get { return _pathStep >= _path.Length;} } // Property has scored if reached the end of the path
    
    //computed property that will return true if the invader is neutralized
    
    public bool IsNeutralized => Health <= 0;
    
    public bool IsActive => !(IsNeutralized || HasScored);
    
    public Invader(Path path)
    {
      _path = path;
    }
    
    public void Move() =>  _pathStep += 1;  
    
    public void DecreaseHealth(int factor)
    {
      Health -= factor;
    }
  }
}