# Strings Practice Project

Welcome to the **Strings Practice** project in C#! This simple console application covers the fundamental concepts related to working with strings.

## Topics Covered

### 1. Strings
- Create and display basic string variables.
- Example:
  ```csharp
  string firstName = "John";
  string lastName = "Doe";
  ```

### 2. Concatenation
- Combine multiple strings using the `+` operator.
- Example:
  ```csharp
  string fullName = firstName + " " + lastName;
  ```

### 3. Interpolation
- Insert variables directly into strings using `$"{}"`.
- Example:
  ```csharp
  Console.WriteLine($"Welcome, {firstName} {lastName}!");
  ```

### 4. Access Strings (Indexing)
- Access specific characters in a string using square brackets `[]`.
- Example:
  ```csharp
  Console.WriteLine(firstName[0]);
  Console.WriteLine(lastName[lastName.Length - 1]);
  ```

### 5. Special Characters
- Use escape sequences like `\n` (new line), `\t` (tab), and `\"` (quote) within strings.
- Example:
  ```csharp
  Console.WriteLine("She said, \"C# is awesome!\"");
  ```

### Bonus Challenge
- Combine all the concepts to create a multi-line, formatted message.

## How to Run

1. Make sure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download) installed.
2. Create a new console project:
   ```bash
   dotnet new console -n StringsPractice
   cd StringsPractice
   ```
3. Replace the content of `Program.cs` with the provided code.
4. Run the project:
   ```bash
   dotnet run
   ```

---

Happy coding! 🎯
