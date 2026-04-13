using System;
using System.IO;

namespace CybersecurityChatbot
{//start of namespace
    public class GreetAndName
    {//start of class

        //global variable
        private string username = string.Empty;

         //void method to welcome user
         public void Welcome()
        {//start of method

            //displaying welcome message with text colour
            //set colour before you print
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[ Welcome to Cybersecurity Awareness Bot ]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("==============================");

            //reset colour to default - this is a void method
            Console.ResetColor();

        }//end of welcome method

        //prompt user for username
        public void AskName() // musn't return anything as we already have a global variable - void
        {//start of AskName method

            //ai chat message and name
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cybersecurity Bot:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hey! what should I call you?");

            Console.ResetColor();

            //do while to re-prompt the user
            do
            {//start of do while

                //user prompting with colour
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Name: ");
                //now set colour for when they enter their name
                Console.ForegroundColor = ConsoleColor.Gray;

                username = Console.ReadLine();

                //reset colour to default
                Console.ResetColor();

            } while (!isEmpty()); //end of do whilr
        }//end of method AskNAme

        //boolean method to check if user entered name
        private Boolean isEmpty()
        {//start of boolean method

            //if statement to check if username is empty or not
            if (username !="")
            {//start if statement
                //return success message if not empty
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cybersecurity Bot");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Nice to meet you " + username + "! "  + "How can I help?");
                

                //return true as they did enter
                return true;
            }//end if statement
            else
            {//start else statement
                //error message
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cybersecurity Bot");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter your name:");

                //return false
                return false;
            }//end else statement

        }//end of boolean method


        public void DisplayLogo()
        {//start of logo method

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("                                                                                                     \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                           *%%%#    =#%%#                                           \r\n                                          -%:  #*  .%=  %#                                          \r\n                                           *%%%*    *%#%#.       ..                                 \r\n                               :###%-       .%:      :%:       :##+#*                               \r\n                               **  +*.      .%:      :%:       =%. -%.                              \r\n                               .#%%%#:      .%:      :%:      =%#%%%-                               \r\n                                    :##.    .%:      :%:    -%+.                                    \r\n                         .:.          ##    .%:      :%:   .#=         .--.                         \r\n                        *%=*#:        ##    .%:      :%:   .#=     ...+#=-%*                        \r\n                       :#- .#%##%#.   ##    .%:      :%:   .#=   +%#**%*. #*                        \r\n                        -#%#+    =%*  ##    .%: .#%: :%:   .#=  *%.    =##+                         \r\n                                  #*  ##    .%+#%-:#%+%:   .#=  *%                                  \r\n                 :.               #*  ##  .+*%+:    .=%#+: .#=  *%               .:                 \r\n              .*%+##:            .#*.-#%#%#-.   +#%*   .:#%%%#=.*%             :%#*%+               \r\n              :%: .#=         #%####*-      .+%%+  -%%*:      -+####%%         +*. =#:              \r\n               -#%%%-         ##    ..:-=#%#+-        :+*%%+-::.    +%         -%%%*-               \r\n        .*%%%=     :##-       ##  #%*+--:                  :--=*%%  +%       -##:     =%%%*.        \r\n        *#. =%:      :%#:     ##  ##                            *%  +%.    :#%:      :%= .#*        \r\n         %%%%*         -######%#  ##          .#%%%%%=          *%  +%######-         *%%%%         \r\n             *%=              ##  ##         :%=    .%=         *%  +%              =%*             \r\n              .*#-            ##  ##         -%.     %=         *%  +%            -%*.              \r\n                :#%%%%%%%%%%%%##  ##       **#%******%#**.      *%  +%%%%%%%%%%%%%#.                \r\n                              ##  ##       %*          :%-      *%  +%                              \r\n         -%%%*                ##  ##       %*    *%.   :%-      *%  *%                *%%%-         \r\n        :%= .%%%%%%%%%%%%%%%%%%%- -%-      %*    =#.   :%-      ##  *%%%%%%%%%%%%%%%%%%  =%.        \r\n         +%*#%.                %+  #*      %*    -#.   :%-     =%. -%:               .##*%+         \r\n                      =#########%: .%=     %%##########%%-    :%= .**                               \r\n                    =%*.        =%. -%=                      .%+  =%%%%%%%%%%-                      \r\n                  -#*.           +%: :##.                   -%=  +#:        :#%-                    \r\n              =#%##:        :+++++%%-  =%+                :#%: .#%.           :##:                  \r\n             =#: -%-       #%-.....:%#. .+%*            .#%-  -%%*****          =%%%%-              \r\n             .%#*%*      *%=        -%%*   *%#:      .+%#:  .%#:.....*%+       .#=  +*              \r\n               ..   .*%%%*          =#.*%+.  :*%#-:*%#=   =#%-        .*%-      :#%%#:              \r\n                   .** .**        .*#-  :%%%=.  .==:   -*%++%.          :#%##+                      \r\n                    +%**%-    . .*%-    :%: %%%*-  .*#%%%  -%=           #*  #%                     \r\n                           -%#*%%=      :%: #+ .*%%%%  *%   .%#:         *%**%=                     \r\n                           =#. -#:     :%#. #+     +%  *%     -#*.:=:      :.                       \r\n                           .=#%*:    :#%:   #+     +%  *%       *%+-*%:                             \r\n                                -%%%%%-     #+     +%  .*%-     -%+.+%:                             \r\n                               .#-  ++      #+     +%    .#%.     +#=                               \r\n                                -#%%#:      #+     +%      -%%*+%*                                  \r\n                                            #+     +%       ##. *%                                  \r\n                                          -#%%#. .*%%%=      =#%+.                                  \r\n                                          **  *% -%. :%:                                            \r\n                                          =%%%#. .*%#%=                                             \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                   ");

            Console.ResetColor();
        }//end of logo method
    }//end of class
}//end of namespace