 Cybersecurity Awareness Chatbot (Part 1)

Description
This project is a C# console-based Cybersecurity Awareness Chatbot developed to educate South African citizens about common cyber threats such as phishing, weak passwords, and unsafe browsing.

The chatbot simulates real-life interactions and provides guidance on how users can protect themselves online while maintaining an engaging conversational experience.

Features

User Interaction
- Prompts user for their name
- Validates input to ensure a name is entered
- Personalises responses using the user’s name

Chatbot Functionality
- Continuous conversation loop
- Responds to user queries using keyword detection
- Handles:
  - Password safety
  - Phishing awareness
  - Safe browsing practices
- Answers general questions such as:
  - “How are you?”
  - “What is your purpose?”
  - “What can I ask you?”
- Handles unknown input with a fallback response
- Allows user to exit by typing `exit`

 Conversational Flow
- Detects when a user says “thank you”
- Responds politely
- Asks if further assistance is needed
- Ends the chat if the user responds with “no”

 Console User Interface
- Uses colour formatting for improved readability
- Structured layout with headings and spacing
- Displays an ASCII art logo at startup

 Voice Greeting
- Plays a `.wav` audio greeting when the application starts
- Enhances user experience with a more interactive feel

Project Structure

- 'Program.cs" → Application entry point and program flow  
- `GreetAndName.cs → Handles greeting and user input  
- 'Chats.cs → Manages chatbot logic and responses
- 'VoicePrompt.cs' - voice greeting

 How to Run the Program

1. Open the project in Visual Studio  
2. Build the solution  
3. Run the application  
4. Ensure the file `greeting.wav` is included in the project and set to:
   - **Copy to Output Directory → Copy if newer**  
5. Follow the prompts in the console  

Continuous Integration (CI)

This project uses **GitHub Actions** for Continuous Integration.

- Automatically builds the project on every push  
- Ensures the application compiles successfully  
- Provides validation through workflow checks  

📷 *Screenshot of successful CI run included below:*


Technologies Used

- C#  
- .NET Framework  
- Console Application  
- GitHub (Version Control)  
- GitHub Actions (CI/CD)

 Project Status

✅ Core chatbot functionality complete  
✅ User interaction and validation implemented  
✅ Keyword-based response system working  
✅ ASCII UI and styling complete  
✅ Voice greeting integrated  
⏳ CI verification does not work 
