# CybersecurityChatBot (part 1)

Description
This project is a C# console-based Cybersecurity Awareness Chatbot designed to educate South African citizens about common online threats such as phishing, weak passwords, and unsafe browsing practices.

The chatbot interacts with users in a conversational manner, providing guidance on how to stay safe online while simulating real-life cyber threat scenarios.

1. Features (Current Progress)
    User Greeting System
  - Displays a styled welcome message
  - Prompts the user for their name
  - Validates input to ensure a name is entered
    
2. Enhanced Console UI
  - Uses colour formatting for readability
  - Includes structured layout and borders
  - Displays an ASCII art logo at startup
    
3. Interactive Chat System
  - Allows continuous conversation with the user
  - Responds to cybersecurity-related keywords such as:
    - Password safety
    - Phishing
    - Safe browsing
  - Handles unknown inputs with a fallback response
  - Allows the user to exit the chat by typing `exit`

4. Keyword Detection Logic
  - Breaks user input into words
  - Ignores unnecessary words (e.g. "what", "is")
  - Matches keywords to predefined cybersecurity responses

 Project Structure

The project is structured using multiple classes for clarity and maintainability:

- `Program.cs` → Entry point of the application  
- `GreetAndName.cs` → Handles greeting and user name input  
- `Chats.cs` → Manages chatbot interaction and responses  

 How to Run the Program

1. Open the project in Visual Studio 
2. Build the solution  
3. Run the program  
4. Follow the prompts in the console  
 Work in Progress

The following features are still being implemented:

- Voice greeting using a `.wav` file  
- Continuous Integration (CI) setup via GitHub Actions  
- Final documentation updates  

---

 Technologies Used

- C#  
- .NET  
- Console Application  
- GitHub (Version Control)  

 CI Status

*(Screenshot will be added once CI is fully configured and passing)*
