using Microsoft.VisualBasic;

public class FeatureCollection {

    public string type { get; set; }
    public Feature[] features { get; set; }
}

public class Feature{
    public string type { get; set; }
    public Properties properties{ get; set; }
}

public class Properties{
    public decimal mag { get; set; }
    public string place { get; set; }
}