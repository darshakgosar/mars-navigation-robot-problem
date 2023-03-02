# Mars Navigation Robot
NASA plans to land a robot on a Mars plateau.

The robot must negotiate this strangely rectangular plateau so that their on-board cameras may get a complete view of the surrounding area to send back to Earth.
The position of a robot is indicated by an x and y coordinate as well as a letter denoting one of the four cardinal compass points. To aid navigation, the plateau has been divided into grids. A location like 1, 1, N indicates that the robot is in the bottom left corner, looking North.

Suppose that (x, y) is the square just north of (x, y).

# Input:

The input of the app will be a series of commands to move the robot on the plateau. Mars plateau is a grid defined by the initial input of the app, such as 5x5, 3x4, etc.

The second input line will be a string containing multiple commands as described below:
The robot will always start at X: 1, Y: 1 facing NORTH. If the robot reaches the limits of the plateau the command must be ignored.
Your goal is to navigate the robot and print the final position.
Example:
Input:
Guideliness
L: Turn the robot left
R: Turn the robot right
F: Move forward on it's facing direction
Sample command string: LFLRFLFF

The robot will always start at X: 1, Y: 1 facing NORTH. If the robot reaches the limits of the plateau the command must be ignored.


# Output:

The output for robot should be its final co-ordinates and heading.

Test Input:

5x5
FFRFLFLF

Expected Output:

1,4,West

# Note

1. There is no limit for the Plateau size
2. Inputs will always be valid, so there is no need to validate them
3. There is no 0,0 position