# Snake
This is the classic snake game, aka the best game on the Nokia 3310 which was a phone released in September of 2000. 
You control the snake, and as you collect the "food" that is on the screen, the length of the snake is increased. 
If you hit the edges, or run into yourself, the game is over.

---
## Getting Started
Make sure you have dotnet 6.0 or newer installed on your machine. Open 
a terminal and browse to the project's root folder. Start the program 
by running the following commands.
```
dotnet build
dotnet run 
```
You can also run the program from an IDE like Visual Studio Code. 
Start your IDE and open the project folder. Select "Run and Debug" on 
the Activity Bar. Next, select the project you'd like to run from the 
drop down list at the top of the Side Bar. Lastly, click the green 
arrow or "start debugging" button.

## Project Structure
The project files and folders are organized as follows:
```
root                    (project root folder)
+-- Game                (source code folder)
+-- Program.cs          (program entry point)    
+-- README.md           (general info)
+-- Unit04.csproj       (dotnet project file)
```

## Required Technologies
* dotnet 6.0
* raylib-cs 3.7.0.1

## Authors
* Aaron Alexander (ale20011@byui.edu)


Polymorphism is the concept of making a methods behavior change based on the class that it is referring to. This allows you to ensure that the value that is returned has been manipulated in a way that is concurrent with required operations for the specific class that the method is being used in conjunction with.