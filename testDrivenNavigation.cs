using System;
using Xunit;

public class MarsRobotTests {
    [Fact]
    public void Test1() {
        // Arrange
        string plateauSize = "5x5";
        string commandString = "FFRFLFLF";
        string expectedOutput = "1,4,W";

        // Act
        string output = MarsRover.Navigate(plateauSize, commandString);

        // Assert
        Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Test2() {
        // Arrange
        string plateauSize = "3x4";
        string commandString = "FFFFF";
        string expectedOutput = "1,4,N";

        // Act
        string output = MarsRover.Navigate(plateauSize, commandString);

        // Assert
        Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void Test3() {
        // Arrange
        string plateauSize = "10x10";
        string commandString = "LFFFFRFFFFRFFFFRFFFF";
        string expectedOutput = "5,5,N";

        // Act
        string output = MarsRover.Navigate(plateauSize, commandString);

        // Assert
        Assert.Equal(expectedOutput, output);
    }
}

public class MarsRover {
    public static string Navigate(string plateauSize, string commandString) {
        // Read the plateau size
        string[] plateauDimensions = plateauSize.Split('x');
        int plateauWidth = int.Parse(plateauDimensions[0]);
        int plateauHeight = int.Parse(plateauDimensions[1]);

        // Initialize robot position and direction
        int robotX = 1;
        int robotY = 1;
        // N - North
        // S - South
        // W - West
        // E - East
        char robotDirection = 'N';

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

        // Return the final position of the robot as a string
        return robotX + "," + robotY + "," + robotDirection;
    }
}
