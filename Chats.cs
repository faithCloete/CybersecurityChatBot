using System;
using System.Collections.Generic;
using System.Configuration;

namespace CybersecurityChatbot
{//start of namespace

    public class Chats
    {//start of class

        //list to store chatbot answers
        List<string> answers = new List<string>();

        //list to store words we want to ignore
        List<string> ignoring = new List<string>();


        //method to handle chatting
        public void AiChat(string name)
        {
            //adding responses (only runs once ideally, but fine here for now)
            answers.Add("passwords: In technology, a password is a secret string of characters (letters, numbers, symbols, or spaces) used to authenticate a user's identity and grant access to a system, device, application, or data. To create one, use at least 8 characters with letters, numbers, and symbols.");
            answers.Add("phishing: In technology and cybersecurity, phishing is a type of social engineering attack where an attacker impersonates a legitimate person, company, or organization to trick a victim into revealing sensitive information (like passwords, credit card numbers, or personal data) or installing malware. Be careful of emails asking for personal information.");
            answers.Add("browsing: Browsing (or web browsing) refers to the act of navigating and accessing information on the World Wide Web using a software application called a web browser (e.g., Chrome, Firefox, Safari, Edge). Only visit secure websites and avoid suspicious links.");
            answers.Add("how: I'm a robot designed with care, to help you stay safe online.");
            answers.Add("purpose: My purpose is to educate you about cybersecurity threats and how to avoid them as much as possible, when using technology.");
            answers.Add("ask: You can ask me about passwords, phishing, and safe browsing.");

            //words to ignore
            

            string asking = string.Empty;

            //loop until user types "exit"
            do
            {
                //user input
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(name + ": ");
                Console.ResetColor();

                asking = Console.ReadLine();

            } while (EndChat(asking)); //keep looping while true

        }//end of AiChat method


        //method to check input and respond
        private bool EndChat(string question)
        {
            //check if user says thank you
            if (question.ToLower().Contains("thank"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cybersecurity Bot: You're welcome! Is there anything else I can help you with? (yes/no)");
                Console.ResetColor();

                //get response
                string response = Console.ReadLine().ToLower();

                if (response == "no")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Cybersecurity Bot: Alright, stay safe online. Goodbye!");
                    Console.ResetColor();
                    return false; //end chat
                }
                else
                {
                    return true; //continue chat
                }
            }
            //check if user wants to exit
            if (question.ToLower() == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cybersecurity Bot: Stay safe online. Goodbye.");
                Console.ResetColor();
                return false; //stop chat
            }

            //split sentence into words
            string[] words = question.ToLower().Split(' ');

            bool found = false;

            //loop through each word user typed
           
            foreach (string word in words)
            {
                //skip ignored words
                if (ignoring.Contains(word))
                {
                    continue;
                }

                //SECOND loop (this is what you're missing or broke)
                foreach (string answer in answers)
                {
                    //split answer into keyword and message
                    string[] parts = answer.Split(':');

                    string keyword = parts[0];
                    string message = parts[1];

                    if (word == keyword)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Cybersecurity Bot: " + message);
                        Console.ResetColor();

                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            //if nothing matched
            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Cybersecurity Bot: I don't understand. Try asking about passwords, phishing, or browsing.");
                Console.ResetColor();
            }

            return true; //continue chat

        }//end of EndChat method

    }//end of class

}//end of namespace
