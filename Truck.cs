
public class Truck : Car 
{
    String MaxLoadWeight;
    int NumberOfWheels;
    public Truck(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, String WheelsPower, String Fuel, String weight, int wheels){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.NumOfPassengers=NumOfPassengers;
        this.NumOfDoors=NumOfDoors;
        this.WheelsPower=WheelsPower;
        this.Fuel=Fuel;
        MaxLoadWeight=weight;
        NumberOfWheels=wheels;


        System.Console.WriteLine("Truck istructor is called!");

    }
    public  void MoveForward(){
        System.Console.WriteLine("Move Forward!");
    }
    public  void Turn(String Direction){
        System.Console.WriteLine($"Turn {Direction}!");
    }
    public  void Stop(){
       System.Console.WriteLine("STOP!");
    }
    public void Switch(){
       System.Console.WriteLine("switche on!");
    }
    /*public bool AirbagFacilition(){
       System.Console.WriteLine("switche on!");
    }    */
    public  void toString(){
       System.Console.WriteLine($"truck key type {KeyId}, truck Fuel type {Fuel}");
    }
    
}
