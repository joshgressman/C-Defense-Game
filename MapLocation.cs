using System;

namespace TreehouseDefense
{
  class MapLocation : Point //Now inherits the Point class Is now a sub class MapLocation is also a Point. Must fill in the constructor to create
  {
    public MapLocation(int x, int y, Map map) : base(x, y) //Construcor fromt the Point class : base calls the base class base class means Parent Class
    {
      //Validation to make sure the map location is a valid point on the map
      if (!map.OnMap(this)) // used the OnMap method from Map.cs for the conditional this refers to the current object
      {
        throw new OutOfBoundsException(x + "," + y + " is outside the boundries of the map"); //Creates a new exception
      }
    }
    
    public bool InRangeOf(MapLocation location, int range)
    {
      return DistanceTo(location) <= range;
    }
    
  }
}