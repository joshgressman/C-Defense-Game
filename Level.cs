namespace TreehouseDefense
{
  class Level
  {
    
    private readonly Invader[] _invaders;
    
    public Tower[] Towers {get; set;}
    
    public Level(Invader[] invaders) //constructor
    {
      _invaders = invaders;
    }
    //returns true if the player wins returns false if invader reaches the end of the path
    public bool Play()
    {
      
      //Run until all invaders are neutralized or an invader reaches the end of the path
      int remainingInvaders = _invaders.Length;
      
      while(remainingInvaders > 0)
      {
      //first each tower has an opportunity to fire on invaders
      foreach(Tower tower in Towers)
      {
        tower.FireOnInvaders(_invaders);
      }
        
      //count and move the invaders that are still active
        remainingInvaders = 0;
        foreach(Invader invader in _invaders)
                {
                  if(invader.IsActive)
                  {
                    invader.Move();
                    
                    if(invader.HasScored)
                    {
                      return false; //invader has scored
                      
                    }
                    
                    remainingInvaders++;
                  }
                }
            }
            return true;
    }
  }
} 
