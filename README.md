# Game Data Parser

A robust C# console application that reads and parses video game data from a user-specified JSON file, with comprehensive error handling and logging capabilities.

## Description

The **Game Data Parser** is a console application developed as part of the Ultimate C# Masterclass Assignment. It allows users to input a JSON file name containing video game data (e.g., title, release year, rating), parses the data, and displays it in the console. The application is designed to handle invalid inputs and JSON files gracefully, logging all unhandled exceptions (e.g., invalid JSON or file not found) to a `log.txt` file. Built with .NET 8, it ensures stability and provides clear feedback for both successful and failed operations.

## Getting Started

### Dependencies

- **.NET 8 SDK**: Required to build and run the application.
- **Operating System**: Cross-platform (Windows, macOS, Linux).
- **Libraries**: Uses `System.Text.Json` for JSON parsing (included in .NET 8).
- **Sample Files**: JSON files (e.g., `games.json`) must be placed in the `bin\Debug\net8.0` folder for testing.

### Installing

- Clone the repository:

  ```bash
  git clone https://github.com/your-username/game-data-parser.git
  ```

- Navigate to the project directory:

  ```bash
  cd game-data-parser
  ```

- Restore dependencies:

  ```bash
  dotnet restore
  ```

- Build the project:

  ```bash
  dotnet build
  ```

- Place sample JSON files (e.g., `games.json`, `gamesInvalidFormat.json`) in the `bin\Debug\net8.0` folder.

### Executing Program

- Run the application:

  ```bash
  dotnet run
  ```

- Follow these steps:

  1. When prompted, enter the JSON filename (e.g., `games.json`). Ensure the `.json` extension is included.

     ```
     Enter the name of the file you want to read:
     ```

  2. If the file is valid, the application will display the parsed game data:

     ```
     Loaded games are:
     Stardew Valley, released in 2016, rating: 4.9
     Frostpunk, released in 2017, rating: 4.7
     Oxygen Not Included, released in 2017, rating: 4.8
     Red Dead Redemption II, released in 2018, rating: 4.8
     Portal 2, released in 2011, rating: 4.8
     ```

  3. If the file is invalid, an error message is displayed in red, and the exception is logged to `log.txt`:

     ```
     JSON in the gamesInvalidFormat.json was not in a valid format. JSON body:
     [CONTENT OF THE FILE]
     Sorry! The application has experienced an unexpected error and will have to be closed.
     ```

  4. Press any key to close the application.

## Help

Common issues and solutions:

- **"File not found"**: Ensure the JSON file is in the `bin\Debug\net8.0` folder and the filename includes the `.json` extension.
- **"File name cannot be null"**: Avoid pressing Ctrl+Z without entering a filename.
- **"File name cannot be empty"**: Enter a valid filename instead of leaving the input blank.
- **Invalid JSON error**: Verify the JSON file syntax (e.g., check for missing commas). Use the provided `games.json` as a reference.
- **Log file not created**: The `log.txt` file is only created when an unhandled exception occurs. Check `bin\Debug\net8.0` for the file after an error.

For additional help, run the program and follow the prompts:

```bash
dotnet run
```

## Authors

- [Your Name] (Please provide your name and contact info, e.g., GitHub profile or email)

## Version History

- 0.1
  - Initial release: Implements JSON parsing, input validation, and exception logging.

## Features

- **User Input Handling**:
  - Validates filename input (handles null, empty, or non-existent files).
  - Repeats prompt until a valid `.json` file is provided.
- **JSON Parsing**:
  - Safely deserializes JSON arrays with video game data (title, release year, rating).
  - Handles invalid JSON with clear error messages and logs exceptions.
- **Exception Logging**:
  - Logs unhandled exceptions to `log.txt` with:
    - Date and time
    - Exception message
    - Stack trace
  - Appends new logs without overwriting existing ones.
- **Console Output**:
  - Displays game data or error messages (errors in red).
  - Shows "No games are present in the input file" for empty JSON arrays.

## Sample Files

Test the application with these sample JSON files:

- **Valid JSON** (`games.json`):

  ```json
  [
    {
      "Title": "Stardew Valley",
      "ReleaseYear": 2016,
      "Rating": 4.9
    },
    {
      "Title": "Frostpunk",
      "ReleaseYear": 2017,
      "Rating": 4.7
    },
    {
      "Title": "疏忽大意 Not Included",
      "ReleaseYear": 2017,
      "Rating": 4.8
    },
    {
      "Title": "Red Dead Redemtpion II",
      "ReleaseYear": 2018,
      "Rating": 4.8
    },
    {
      "Title": "Portal 2",
      "ReleaseYear": 2011,
      "Rating": 4.8
    }
  ]
  ```

- **Invalid JSON** (`gamesInvalidFormat.json`):

  ```json
  [
    {
      "Title": "Stardew Valley",
      "ReleaseYear": 2016,
      "Rating": 4.9
    }
    {
      "Title": "Frostpunk",
      "ReleaseYear": 2017,
      "Rating": 4.7
    },
    {
      "Title": "Oxygen Not Included",
      "ReleaseYear": 2017,
      "Rating": 4.8
    },
    {
      "Title": "Red Dead Redemtpion II",
      "ReleaseYear": 2018,
      "Rating": 4.8
    },
    {
      "Title": "Portal 2",
      "ReleaseYear": 2011,
      "Rating": 4.8
    }
  ]
  ```

- **Sample Log File** (`log.txt`):

  ```
  [12/1/2022 8:00:13 AM], Exception message: Unexpected character encountered ..., Stack trace: ...
  ```

### How to Use Sample Files

1. Place the JSON file in the `bin\Debug\net8.0` folder.
2. Run the application:

   ```bash
   dotnet run
   ```

3. Enter the filename when prompted (e.g., `games.json`).
4. Ensure the `.json` extension is included.

⚠️ **Note**: The JSON file must be in `bin\Debug\net8.0`.

## Development Notes

- **Target Framework**: .NET 8.0
- **JSON Parsing**: Uses `System.Text.Json` with try-catch blocks for safe parsing.
- **Logging**: Uses `StreamWriter` in append mode for `log.txt`.
- **Working Directory**: JSON files must be in `bin\Debug\net8.0`.
