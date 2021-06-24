public class Bicycle : Motorcycle{
public Bicycle(int ID,int Color, int SerialNumber){
        this.Id=ID;
        this.Color=Color;
        this.SerialNumber=SerialNumber;


        System.Console.WriteLine("Bicycle istructor is called!");

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

    public  void toString(){
       System.Console.WriteLine($"Bicycle Id is " +Id);
    }
    
}
