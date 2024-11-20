namespace MyFirstProgram.Models;

internal class Game
{

    //pattern of a backing field and a getter/setter

    private int _score; //private means this variable cannot be accessed from outside this class
        // the private field that is not exposed is called a backing field

    //public int Score //this is the variable which will be exposed to the other classes. This public variable is a property of a class
    //{
    //    get { return _score; }
    //    set { _score = value; }
    //}

    public DateTime Date { get; set; } //this is a property of the class Game. It is a public property, so it can be accessed from outside this class
    public int Score { get; set; } //this is the same thing as above, but in a shorter way
    public GameType Type { get; set; } 

}


    //a model class will hold properties that are related to the class

    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }