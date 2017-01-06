//This file houses custom Exceptions specific to the TreehouseDefense Game

namespace TreehouseDefense
{
  class TreehouseDefenseException : System.Exception //Exceptions originated inside Defense app INHERITS from SyStemException Class
  {
    public TreehouseDefenseException()
    {
    }
    public TreehouseDefenseException(string message) : base(message)
    {
      
    }
  }
  
  class OutOfBoundsException : TreehouseDefenseException
  {
    public OutOfBoundsException() //Constructor with no parameters for Exceptions that dont need messages
    {
    }
    public OutOfBoundsException(string message): base(message) //Constructor for the Exception Class
    {
      
    }
  }
}