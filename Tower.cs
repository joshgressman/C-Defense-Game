namespace TreehouseDefense
{
  class Tower
  {
    private const int _range = 1; //constant range vairable will not change 
    
    private const int _power = 1; //constant range vairable will not change 
    
    //public field
    private readonly MapLocation _location;
    
    //Constructor to set the location fields
    public Tower(MapLocation location)
    {
      _location = location;
    }
    
    public void FireOnInvaders(Invader[] invaders)
    {
      
      
      foreach(Invader invader in invaders)
      {
        if(invader.IsActive && _location.InRangeOf(invader.Location, _range)) //range tower is 1
        {
          invader.DecreaseHealth(_power); //const varible = 1
          break;
        }
      }
    }
  }
}