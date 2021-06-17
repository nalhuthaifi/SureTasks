


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

