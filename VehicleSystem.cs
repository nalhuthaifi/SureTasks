abstract class Vehicle //base class
{

    public abstract int Id;
    public abstract int Color;
    public abstract int SerialNumber;

    public abstract void MoveForward();
    public abstract void Turn(String Direction);
    public abstract void Stop();

}
public class Key{
    int Id;
 }

 public class color{
    int Id;
 }

public interface VehicleWithRoof{
    public bool OpenRoof();
}

abstract class Car : Vehicle 
{
    public abstract int KeyId;
    public abstract int NumOfPassengers;
    public abstract int NumOfDoors;
    public abstract String WheelsPower;
    public abstract String Fuel;
    public abstract void Switch();
 //   public abstract bool AirbagFacilition();
}

abstract class Motorcycle : Vehicle 
{

}

public class Bus : Car 
{
    public Bus(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, String WheelsPower, String Fuel){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.NumOfPassengers=NumOfPassengers;
        this.NumOfDoors=NumOfDoors;
        this.WheelsPower=WheelsPower;
        this.Fuel=Fuel;

        System.Console.WriteLine("Bus istructor is called!");

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
    public  void toString(){
       System.Console.WriteLine($"Bus key type {KeyId}, bus Fuel type {Fuel}");
    }
    
}



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


public class Sedan : Car , VehicleWithRoof
{
    public Sedan(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, String WheelsPower, String Fuel){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.NumOfPassengers=NumOfPassengers;
        this.NumOfDoors=NumOfDoors;
        this.WheelsPower=WheelsPower;
        this.Fuel=Fuel;

        System.Console.WriteLine("Sedan istructor is called!");

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
    public bool OpenRoof(){
        ///////////////////ASK ABOUT THIS
          System.Console.WriteLine($"Sedan roof is ");
    }
    public  void toString(){
       System.Console.WriteLine($"Sedan key type {KeyId}, bus Fuel type {Fuel}");
    }
    
}


public class SUV : Car , VehicleWithRoof
{
    public Sedan(int ID,int Color, int SerialNumber, int KeyId,int NumOfPassengers, int NumOfDoors, String WheelsPower, String Fuel){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;
        this.NumOfPassengers=NumOfPassengers;
        this.NumOfDoors=NumOfDoors;
        this.WheelsPower=WheelsPower;
        this.Fuel=Fuel;

        System.Console.WriteLine("SUV istructor is called!");

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
    public bool OpenRoof(){

        /*

        ///////////////////ASK ABOUT THIS


        */
          System.Console.WriteLine($"SUV roof is ");
    }
    public  void toString(){
       System.Console.WriteLine($"SUV key type {KeyId}, bus Fuel type {Fuel}");
    }
    
}
