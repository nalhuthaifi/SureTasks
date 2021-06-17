
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
