*READ_ME*

Elevators app is a program that controls the elevators, and tells each elevator which floor to travel to next. The building is 10 stories tall. The lobby is floor 0, and the penthouse is floor 10. The building contains one basement (floor -1).
The building has 2 elevators: A and B. Elevator A goes to all floors except the penthouse (floor 10). Elevator B goes all the way up (including 10) but does not go to the basement (-1).
This app is developed in C#. Classes are used and inheritance also applied. public class A_Direction has 2 boolean methods (up and down). public class B_Direction inherits these methods from A_Direction.

There are 2 elevators represented by classes Elevator A and Elevator B. Elevator B inherits methods from Elevator A. The residents of the building can call the elevators by clicking the up or down buttons located next to the 
elevator shafts on their floor. This is represented by up and down methods in both elevators. There is a timer of 1 second in both elevators. It takes 1 second to move to the next floor. Elevator A has buttons -1 to 9 and 
Elevator B has buttons 0 to 10. These buttons represent the floors. For example, pressing 0 in elevator B will take the elevator to the Lobby and print  "B: move to the Lobby". There are also emergency and reset buttons in each elavator. 
If emergency button is pushed, it prints "emergency button activated" and opens the elevator door until reset button is pushed. If reset button is pushed, it prints "Reset button pushed: Closing Elevator".

Thank you for using our app. Developed by Uchenna.


