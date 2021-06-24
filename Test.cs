using System;
namespace MainCode
{
    class Test
    {
        static void Main(string[] args)
        {
            var choice;
            var exit=1;
            String direction;
            do{
                Console.WriteLine(" Enter 1 for Cars and 2 for Motorcycle ");
                
                bool flag;
                Console.WriteLine("Welcome");
                Console.WriteLine(" Enter 1 for Cars and 2 for Motorcycle");
                var VehicleType = Int32.Parse(Console.ReadLine());
                flag=true;
                while(flag){
                    if(VehicleType!=1&&VehicleType!=2){
                        Console.WriteLine("Wrong choice, please enter 1 for car or 2 for motorcycle");
                        VehicleType = Int32.Parse(Console.ReadLine());
                    }else{
                        flag=false;
                    }
                }

                switch (VehicleType){

                    case 1:
                        Console.WriteLine("Which Type of cars you are looking for?");
                        Console.WriteLine("1- Bus");
                        Console.WriteLine("2- Sedan");
                        Console.WriteLine("3- SUV");
                        Console.WriteLine("4- Truck");
                        var CarType = Int32.Parse(Console.ReadLine());
                        flag=true;
                        
                        while(flag){
                        if(CarType!=1&&CarType!=2&&CarType!=3&&CarType!=4){
                            Console.WriteLine("Wrong choice, please enter a right choice number");
                            VehicleType = Int32.Parse(Console.ReadLine());
                        }else{
                                flag=false;
                            }
                        }
                    
                        switch (CarType){
                            case 1:
                                Bus busObject= new Bus(1,1,1,1,20,2,"4x4","91");
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   Switch (on/off)");
                                Console.WriteLine("2-   move forward");
                                Console.WriteLine("3-   Turn (right/left)");
                                Console.WriteLine("4-   stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    busObject.Switch();
                                }else if(choice=2){
                                    busObject.MoveForward();
                                }else if(choice=3){
                                    String direction;
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    busObject.Turn(direction);
                                }else if (choice=4){
                                    busObject.Stop();
                                }

                            break;

                            case 2:
                                Sedan sedanObject= new Sedan(1,1,1,1,20,2,"4x4","95");
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   Switch (on/off)");
                                Console.WriteLine("2-   move forward");
                                Console.WriteLine("3-   Turn (right/left)");
                                Console.WriteLine("4-   Open/close roof");
                                Console.WriteLine("5-   Stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    sedanObject.Switch();
                                }else if(choice=2){
                                    sedanObject.MoveForward();
                                }else if(choice=3){
                                    
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    sedanObject.Turn(direction);
                                }else if(choice=4){
                                    sedanObject.OpenRoof();
                                }else if (choice=5){
                                    sedanObject.Stop();
                                }


                            break;

                            case 3:
                                SUV suvObject= new SUV(1,1,1,1,20,2,"4x4","95");
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   Switch (on/off)");
                                Console.WriteLine("2-   move forward");
                                Console.WriteLine("3-   Turn (right/left)");
                                Console.WriteLine("4-   Open/close roof");
                                Console.WriteLine("5-   Stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    suvObject.Switch();
                                }else if(choice=2){
                                    suvObject.MoveForward();
                                }else if(choice=3){
                                    
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    suvObject.Turn(direction);
                                }else if(choice=4){
                                    suvObject.OpenRoof();
                                }else if (choice=5){
                                    suvObject.Stop();
                                }


                            break;

                            case 4:

                                Truck truckObject= new Truck(1,1,1,1,20,2,"4x4","95","2000 kg", 8);
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   Switch (on/off)");
                                Console.WriteLine("2-   move forward");
                                Console.WriteLine("3-   Turn (right/left)");
                                Console.WriteLine("4-   Stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    truckObject.Switch();
                                }else if(choice=2){
                                    truckObject.MoveForward();
                                }else if(choice=3){
                                    
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    truckObject.Turn(direction);
                                }else if (choice=4){
                                    truckObject.Stop();
                                }
                            break;
                        }
                    break;

                    case 2:

                        Console.WriteLine("Which Type of Motorcycle you are looking for?");
                        Console.WriteLine("1- Motor");
                        Console.WriteLine("2- Bicycle");

                        var MotorcycleType = Int32.Parse(Console.ReadLine());
                        flag=true;
                        
                        while(flag){
                        if(MotorcycleType!=1&&MotorcycleType!=2){
                            Console.WriteLine("Wrong choice, please enter a right choice number");
                            MotorcycleType = Int32.Parse(Console.ReadLine());
                        }else{
                                flag=false;
                            }
                        }

                        switch(MotorcycleType){
                            case 1: 

                                Motor motorObject= new Motor(1,1,1,1,20,2,"4x4","95");
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   Switch (on/off)");
                                Console.WriteLine("2-   move forward");
                                Console.WriteLine("3-   Turn (right/left)");
                                Console.WriteLine("4-   Stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    motorObject.Switch();
                                }else if(choice=2){
                                    motorObject.MoveForward();
                                }else if(choice=3){
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    motorObject.Turn(direction);
                                }else if (choice=4){
                                    motorObject.Stop();
                                }


                            



                            break;

                            case 2:
                                Bicycle motorObject= new Bicycle(1,1,1);
                                Console.WriteLine("what action you want to be performed?");
                                Console.WriteLine("1-   move forward");
                                Console.WriteLine("2-   Turn (right/left)");
                                Console.WriteLine("3-   Stop");
                                Console.WriteLine("0-   Exit System");
                                choice = Int32.Parse(Console.ReadLine());

                                if(choice=0){
                                    exit=0;
                                }else if(choice=1){
                                    motorObject.MoveForward();
                                }else if(choice=2){
                                    Console.WriteLine("enter direction");
                                    direction = Console.ReadLine();
                                    motorObject.Turn(direction);
                                }else if (choice=3){
                                    motorObject.Stop();
                                }
                            break;
                        }
                    break;
                }
            }while(exit==1);
        }
    }
}
