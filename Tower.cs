using System;

namespace TreehouseDefense
{
  class Tower
  {
    private const int _range = 1; //constant range vairable will not change

    private const int _power = 1; //constant range vairable will not change

    private const double _accuracy = .75;

    private static readonly Random _random = new Random();

    //public field
    private readonly MapLocation _location;

    //Constructor to set the location fields
    public Tower(MapLocation location)
    {
      _location = location;
    }

    public bool IsSuccessfullShot()
    {
      return _random.NextDouble() < _accuracy;

    }

    public void FireOnInvaders(Invader[] invaders)
    {


      foreach(Invader invader in invaders)
      {
        if(invader.IsActive && _location.InRangeOf(invader.Location, _range)) //range tower is 1
        {
          if(IsSuccessfullShot())
          {
          invader.DecreaseHealth(_power); //const varible = 1
            Console.WriteLine("Shot at and hit invader");

            if(invader.IsNeutralized)
            {
              Console.WriteLine("Invader Neutralized");
            }
          }
          else
          {
            Console.WriteLine("Shot at and missed invader");
          }
          break;
        }
      }
    }
  }
}
