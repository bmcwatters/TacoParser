namespace LoggingKata
{
    public interface ITrackable //specifies behavior
    {
        string Name { get; set; }         //property 
        Point Location { get; set; }      //each taco bell has a name and location
                                          // Point refers to a struct (similar to a class) 
    }
}