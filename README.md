<h1 align="center">Code Smells - Tic-Tac-Toe example</h1>

<p align="center">
  <a href="#about">About</a> &#xa0; | &#xa0;
  <a href="#features">Features</a> &#xa0; | &#xa0;
  <a href="#technologies">Technologies</a> &#xa0; | &#xa0;
  <a href="#getting-started">Getting Started</a> &#xa0; | &#xa0;
  <a href="https://github.com/DussanFreire" target="_blank">Author</a>
</p>

<br>

## 📜 About
This is a simple Tic-Tac-Toe game coded in C#. The project was intentionally designed with code smells to provide a practical example for refactoring exercises. The current code structure has issues like poor naming conventions, duplicated logic, and improper handling of winning conditions, making it a great candidate for improvement.

## ✨ Features

*	2-player game: Players alternate turns using x and *.
*	Basic validation: Prevents moves in already occupied spots.
*	Console-based interface: Played directly in the terminal.

## 👃 Code smells
Code smells are indicators of potential problems in your code that may not be bugs but suggest weaknesses or bad practices. They serve as red flags that signal the need for refactoring, meaning that while the code may still function correctly, it could be structured better for maintainability, readability, and scalability. This code has several code smells that can be identified and improved. Here’s an analysis of the major code smells found:

1. Magic Numbers

* Numbers like 1 for player input and 0 for quitting the game are used directly in the code (if (ketchup == 1), ketchup != 0).
* Solution: Use constants or enums for better readability and maintainability.
```csharp
const int NEW_GAME = 1;
const int EXIT = 0;
```

2. Poor Variable Naming:

*	Variables like ketchup, t1, haha, hehe do not have meaningful names. This makes the code harder to understand and maintain.
*	Solution: Use descriptive variable names that represent the data they hold or the purpose they serve. For example:
    * ketchup → userOption
 	* t1 → turn
 	* haha, hehe → row, col

3. Duplication of Code (Repetitive Conditions):
* The conditions that check for a winner are repeated for both players (x and *). The logic is identical except for the symbol.
* Solution: Extract the win condition check into a separate method that takes the symbol as a parameter.

```csharp
bool CheckWinner(string[,] board, string symbol)
{
    return (board[0, 0] == symbol && board[0, 1] == symbol && board[0, 2] == symbol) ||
           (board[1, 0] == symbol && board[1, 1] == symbol && board[1, 2] == symbol) ||
           (board[2, 0] == symbol && board[2, 1] == symbol && board[2, 2] == symbol) ||
           (board[0, 0] == symbol && board[1, 0] == symbol && board[2, 0] == symbol) ||
           (board[0, 1] == symbol && board[1, 1] == symbol && board[2, 1] == symbol) ||
           (board[0, 2] == symbol && board[1, 2] == symbol && board[2, 2] == symbol) ||
           (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
           (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol);
}
```

4. Long Method (God Method):
* The Main method does too many things, from handling the game menu to the game loop, checking win conditions, drawing the board, and getting user input. This violates the Single Responsibility Principle.
* Solution: Break the Main method into smaller methods with clear responsibilities, such as DisplayMenu(), HandleTurn(), PrintBoard(), CheckWinner(), etc.

5. Hard-Coded Symbols and Input Strings:
* The symbols ("x" and "*") are hard-coded multiple times throughout the code.
* Solution: Use constants or pass the symbols as parameters where needed

```csharp
const string PLAYER_ONE_SYMBOL = "x";
const string PLAYER_TWO_SYMBOL = "*";
```

6. Lack of Input Validation:
* Input parsing with int.Parse(Console.ReadLine()) can throw an exception if the input is invalid (non-numeric).
* Solution: Add proper input validation to handle invalid or unexpected user input.

```csharp
bool isValidInput = int.TryParse(Console.ReadLine(), out int value);
```

7. Poor User Experience (Coordinate Inputs):
* The input prompt for coordinates can be improved. It’s easy to confuse the user with zero-indexed coordinates internally but one-indexed for input.
* Solution: Consistently use one-indexed coordinates both internally and externally, or explain the indexing clearly to the user.

8. Violation of the DRY Principle (Repeated Code Block for Printing the Board):
* The code to print the board is repeated twice.
* Solution: Create a separate method to handle board display.

```csharp
void PrintBoard(string[,] board)
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            Console.Write($"{board[row, col]} {((col < 2) ? "\t" : "\n")}");
        }
    }
}
```

9. Misleading Booleans (Variable winner):
* The variable winner is initialized as true, but its purpose is to check whether the game continues or not. This can be misleading.
* Solution: Rename the variable to something more appropriate, like gameActive.

10. Console.ReadLine() Assumptions:
* The code assumes that input is always correctly entered (i.e., it will always be an integer). This might break if the input is not as expected.
* Solution: Implement error handling for invalid inputs.

## 🚀 Technologies

* C#: This project is built using C# and can be executed on any environment that supports it.

## ✅ Getting Started

To run the project locally:

```bash
# Clone this repository
$ git clone https://github.com/DussanFreire/tic-tac-toe-code-smells

# Navigate to the project folder
$ cd tic-tac-toe-code-smells

# Open the project in your favorite C# IDE (e.g., Visual Studio, Rider) and run the program.
```

<p align="center">
  <a href="#top">Back to top</a>
</p>
