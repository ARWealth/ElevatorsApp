using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Elevators_Project
{   

public class A_Direction{
    public bool Up;
    public bool Down;
}

public class B_Direction:A_Direction{}

public class ElevatorA { 
public bool Open = false;
public bool EmerButton = true;
public bool ResetBtn = true;

public int Basement;
public int Lobby;
public int Floor1;
public int Floor2;
public int Floor3;
public int Floor4;
public int Floor5;
public int Floor6;
public int Floor7;
public int Floor8;
public int Floor9;
}

public class ElevatorB: ElevatorA {
public int Penthouse;
}

    class Program
    {

        static void Main(string[] args)
        {
           Timers(); 
          // CallButtons();           //call buttons method          
           Elevator_Floors();       //call the elevator floors method
           Emergency();             //activate emergency button
        }

       static void Elevator_Floors(){

           //elevator A
            var elA = new ElevatorA();
            elA.Basement=-1;
            elA.Lobby=0;
            elA.Floor1=1;
            elA.Floor2=2;
            elA.Floor3=3;
            elA.Floor4=4;
            elA.Floor5=5;
            elA.Floor6=6;
            elA.Floor7=7;
            elA.Floor8=8;
            elA.Floor9=9;


            //if elevatorA is not open, move to different floors
            if(elA.Open==false){
       
                if (elA.Basement==-1){
                Console.WriteLine(" A: move to the Basement");}

                if (elA.Lobby==0){
                Console.WriteLine(" A: move to the Lobby");}

                if(elA.Floor1==1){
                Console.WriteLine(" A: move to the first floor");}

                if(elA.Floor2==2){
                Console.WriteLine(" A: move to the second floor");         }

                if(elA.Floor3==3){
                Console.WriteLine(" A: move to the third floor");      }
                
                if(elA.Floor4==4){
                Console.WriteLine(" A: move to the fourth floor");      }
                
                if(elA.Floor5==5){
                Console.WriteLine(" A: move to the fifth floor");      }

                if(elA.Floor6==6){
                Console.WriteLine(" A: move to the sixth floor");      }
              
                if(elA.Floor7==7){
                Console.WriteLine(" A: move to the seventh floor");      }
                
                if(elA.Floor8==8){
                Console.WriteLine(" A: move to the eight floor");      }
                
                if(elA.Floor9==9){
                Console.WriteLine(" A: move to the ninth floor");      }
            }
            
            else{
                elA.Open=true;       }
       
            //elevator B   
            var elB = new ElevatorB();

            elB.Lobby=0;
            elB.Floor1=1;
            elB.Floor2=2;
            elB.Floor3=3;
            elB.Floor4=4;
            elB.Floor5=5;
            elB.Floor6=6;
            elB.Floor7=7;
            elB.Floor8=8;
            elB.Floor9=9;
            elB.Penthouse=10;


            //if elevatorB is not open, move to different floors
            if(elB.Open==false){

                if (elB.Lobby==0){
                Console.WriteLine(" B: move to the Lobby");}

                if(elB.Floor1==1){
                Console.WriteLine(" B: move to the first floor");}

                if(elB.Floor2==2){
                Console.WriteLine(" B: move to the second floor");         }

                if(elB.Floor3==3){
                Console.WriteLine(" B: move to the third floor");      }
                
                if(elB.Floor4==4){
                Console.WriteLine(" B: move to the fourth floor");      }
                
                if(elB.Floor5==5){
                Console.WriteLine(" B: move to the fifth floor");      }

                if(elB.Floor6==6){
                Console.WriteLine(" B: move to the sixth floor");      }
              
                if(elB.Floor7==7){
                Console.WriteLine(" B: move to the seventh floor");      }
                
                if(elB.Floor8==8){
                Console.WriteLine(" B: move to the eight floor");      }
                
                if(elB.Floor9==9){
                Console.WriteLine(" B: move to the ninth floor");      }

                if(elB.Penthouse==10){
                Console.WriteLine(" B: move to the Penthouse");        }       
            
            }
            else{
                elB.Open=true;       }

    }

    static void CallButtons(){
            var elA = new ElevatorA(); 

            // Direction for Elevator A
            var aDirection = new A_Direction();
            aDirection.Up=false;
            aDirection.Down=true;     

            if (aDirection.Up && !aDirection.Down)
            { Console.WriteLine("A is going up");}

            else if(!aDirection.Up && aDirection.Down)
            { Console.WriteLine("A is going down");}
                
            else            {
            
            elA.Open=true; 
            Console.WriteLine("A is idle. Open Elevator.");  }


            // Direction for Elevator B
            var elB = new ElevatorB();          
            var bDirection = new B_Direction();
            bDirection.Up=true;
            bDirection.Down=false;

            if (bDirection.Up && !bDirection.Down)
            { Console.WriteLine("B is going up");}

            else if(!bDirection.Up && bDirection.Down)
            { Console.WriteLine("B is going down");}
                
            else {
                
                elB.Open = true;
                Console.WriteLine("B is idle. Open Elevator.");               }

    }


    static void Timers(){
        Timer aTimer = new Timer(1000);     //Timer for elevator A 1000ms = 1 sec
        Timer bTimer = new Timer(1000);     //Timer for elevator B

        aTimer.Elapsed += Timer_Elapsed;
        bTimer.Elapsed += Timer_Elapsed;

        //Start timers
        aTimer.Start();
        bTimer.Start();

        //if any key is pushed, stop timers
        Console.ReadKey();
        aTimer.Stop();
        bTimer.Stop();
    }

    public static void Timer_Elapsed(object sender, ElapsedEventArgs e){
        
        CallButtons(); //call this method every 1 sec
    }


    static void Emergency(){
        var elA = new ElevatorA(); 
        var elB = new ElevatorB();
        
        //emergency button for elevatorA
        if (elA.EmerButton){
            elA.Open=true;      //Open elevator A
            Console.WriteLine("A emergency button activated");

            if(elA.ResetBtn){
                elA.Open=false; //close elevator when reset button is pushed after emergency
                Console.WriteLine("Reset button pushed: Closing Elevator A");          }
                }
        //emergency button for elevatorB
        if(elB.EmerButton){
            elB.Open=true;      //Open elevator B
            Console.WriteLine("B emergency button activated");
    
            if(elB.ResetBtn){
                elB.Open=false; //close elevator when reset button is pushed after emergency
                Console.WriteLine("Reset button pushed: Closing Elevator B");          }
        }


   
       
    }






    
    }


}
