namespace TreehouseDefense
{
  class Map
  {
    public readonly int Width;
    public readonly int Height;
    
    //Constuructor method is used when creating an instance of a new class. Ensures that required fields are set when instantiating an instnce
    public Map(int width, int height) // Paramters must be provided in order to create the instance
    {
      Width = width;
      Height = height;
    }
    
    public bool OnMap(Point point)
    {
      return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
      
    }
  }
}