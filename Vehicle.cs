abstract class Vehicle //base class
{

    public abstract int Id;
    public abstract int Color;
    public abstract int SerialNumber;

    public abstract void MoveForward();
    public abstract void Turn(String Direction);
    public abstract void Stop();

}
