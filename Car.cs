using System;
namespace MainCode
{
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
}
