namespace lklk
{
    public class Card
    {
        public static int count; // class variable 
        private string manufacturer; // these are instance variables
        private int id;
        private string name;
        private double value;
    

    public Card ( int id, string manufacturer, string name, double value) // constructor, notice its name is the same as the class name  
    {
       
        this.id =  id; // 
        this.manufacturer = manufacturer;
        this.name = name;
        this.value = value;
    }

    public string GetManufacturer () // accessor and an instance method 
    {
        return manufacturer;
    }

    public void SetManufacturer (string temp) // mutator and an instance method 
    {
        manufacturer = temp;
    }

    public int GetId () // accessor and an instance method 
    {
        return id;
    }

    public void SetId (int temp) // mutator and an instance method
    {
        id = temp;
    }

    public string GetName() // accessor and an instance method 
    {
        return name;
    }

    public void SetName(string temp)    // mutator and an instance method
    {
        name = temp;
    }

    public double GetValue()    // accessor and an instance method 
    {
        return value;
    }

    public void SetValue (double temp)  // mutator and an instance method
    {
        value = temp;
    }

    public string ToString() // instance method 
    {
        return id + "\t" + manufacturer + "\t" + name + "\t" + value;
    }
    
    public string ToFile() // instance method 
    {
        return id + "#" + manufacturer + "#" + name + "#" + value;
    }

    public static void SetCount(int temp) // class method 
    {
        count = temp;
    }

    public static void IncCount()  //class method 
    {
        count++;
    }

    public static int GetCount() // class method 
    {
        return count;
    }

    }


}