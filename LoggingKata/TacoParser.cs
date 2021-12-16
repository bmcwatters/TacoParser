namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser           //New Class Done!
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)            //Interface Method  Done!
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');                                  //Done!

            // If your array.Length is less than 3, something went wrong     Done!
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogWarning("less than three items.  incomplete data"); //Done!
                // Do not fail if one record parsing fails, return null    Done!
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0     Done!
            var latitude = double.Parse(cells[0]);

            // grab the longitude from your array at index 1      Done!
            var longitude = double.Parse(cells[1]);

            // grab the name from your array at index 2           Done!
            var name = cells[2];

            // Your going to need to parse your string as a `double`   DONE!
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class      DONE!
            // that conforms to ITrackable

            // Then, you'll need an instance of the TacoBell class    Done!
            // With the name and point set correctly
             var point = new Point();
             point.Latitude = latitude;
             point.Longitude = longitude;    
             var tacoBell = new TacoBell();
            
             tacoBell.Name = name;
             tacoBell.Location = point;
       

            // Then, return the instance of your TacoBell class DONE!
            // Since it conforms to ITrackable

            return tacoBell;
        }
    }
}