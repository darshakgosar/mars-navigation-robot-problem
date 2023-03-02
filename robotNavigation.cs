using System;

class MarsRobot {
    static void Main(string[] args) {
        // Read the plateau size
        string[] plateauSize = Console.ReadLine().Split('x');
        int plateauWidth = int.Parse(plateauSize[0]);
        int plateauHeight = int.Parse(plateauSize[1]);

				if(plateauWidth != 0 && plateauHeight != 0){

        // Initialize robot position and direction
        int robotX = 1;
        int robotY = 1;
        // N - North
        // S - South
        // W - West
        // E - East
        char robotDirection = 'N';

        // Read the command string
        string commandString = Console.ReadLine();

        // Iterate over each command in the string
        // L - Turn the robot left
        // R - Turn the robot right
        // F - Move forward on it's facing direction
        foreach (char command in commandString) {
            // Turn the robot left or right
            if (command == 'L') {
                switch (robotDirection) {
                    case 'N': robotDirection = 'W'; break;
                    case 'W': robotDirection = 'S'; break;
                    case 'S': robotDirection = 'E'; break;
                    case 'E': robotDirection = 'N'; break;
                }
            }
            else if (command == 'R') {
                switch (robotDirection) {
                    case 'N': robotDirection = 'E'; break;
                    case 'E': robotDirection = 'S'; break;
                    case 'S': robotDirection = 'W'; break;
                    case 'W': robotDirection = 'N'; break;
                }
            }
            // Move the robot forward
            else if (command == 'F') {
                switch (robotDirection) {
                    case 'N':
                        if (robotY < plateauHeight) robotY++;
                        break;
                    case 'S':
                        if (robotY > 1) robotY--;
                        break;
                    case 'E':
                        if (robotX < plateauWidth) robotX++;
                        break;
                    case 'W':
                        if (robotX > 1) robotX--;
                        break;
                }
            }
        }

        // Print the final position of the robot
        Console.WriteLine(robotX + "," + robotY + "," + robotDirection);
				}else{
        Console.WriteLine("No such position");
				}
    }
}