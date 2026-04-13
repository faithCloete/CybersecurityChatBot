using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

             //greeting.wav code
 VoicePrompt voiceprompt = new VoicePrompt();

 //calling voice method
 voiceprompt.Voice();
            
            //creating an instance for the class GreetAndName with an object name greeting_and_name
            GreetAndName chatbot = new GreetAndName();

            //calling the methods that are in GreetAndName
            //when you declare a method you don't put a semi colon - refer to the GreetAndName page
            chatbot.DisplayLogo();
            chatbot.Welcome();
            chatbot.AskName();

            //chat system
            Chats chatSystem = new Chats();
            chatSystem.AiChat("You");

            
            
        }
    }
}
