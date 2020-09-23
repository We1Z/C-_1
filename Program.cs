// Copyright (c) 2020 Wei Zeng, All Rights Reserved.
using System;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Letting player know that they are about play the game.
            Console.WriteLine("Hello, welcome to Adventure!" + "\n");
            Console.WriteLine("What is your name?" + "\n");
            string name =Console.ReadLine();
            Console.WriteLine("\n" + $"Hello, {name}! Welcome to your adventure......"+ "\n");
            int health = 100;
            
             //Array of 10 locations + Prompt Dialog 
            string[] locationList = new string [13];
            string[] promptList = new string[13];

            locationList[0] = "\nYou enter a floating world, " +
                              "there is a massive floating doughnut shape rock platform located above the sky " + 
                              "\n"+
                              "The bottom of the platform is raw magnetic material look very artificial but broken.\n" + "\n"+
                              "There is only one growing portal in north direction, there are also seven other portals " +
                              "that are not growing surrounds the edge of this floating platform.\n";

            promptList[0] = "What do you do?\n" + "\n"+
                            "a) Type \"North\" to walk in to the north portal. \n";
                            

            locationList[1] = "Through the north portal, you have enter a blizzard world with mythical creature's cave,\n"+"\n"+
                              "Now, you are approaching the cave \n"+ "\n"+
                              "The snowstorming is blowing right into your face. \n" + "\n" + $" Player Stats || HP: {health} || Mana:100 || " + "\n";

            promptList[1] = "What do you do?\n" + "\n"+
                            "a) Type \"Cave\" to Enter the cave kill the monster inside....\n" + 
                            "b) Type \"Back\" to Walk back to the portal\n";

            locationList[2] = "Then after transfer back to the rock platform, two of the portals in west and east direction starting to grow in red and blue color\n"+"\n"+
                               "\n" + $" Player Stats || HP: {health - 10} || Mana:100 || " + "\n";

            promptList[2] = "What do you do?\n" + "\n"+
                            "a) Type \"Red\" to go into the West Portal. \n" + 
                            "b) Type \"Blue\" to Go into the East Portal. \n";
            
            locationList[3] = "The red growing portal in the west will lead to an area with a huge flame mountain, there is a kid that is the cause of all the fire in the area. Fire is all over the mountain. Heat damage caused by fire"
            + $" Player Stats || HP: {health -20 } || Mana:100 || " + "\n";

            promptList[3] = "What do you do?\n" + "\n"+
                            "a) Type \"Run\" to find the a way out of the situation. \n";

            locationList[4] = "Heading towards the East portal, it will get you on a boat on a dark sea area. The old man on the boat told you that by diving into a cave underneath the water will get you an ancient artifact." +
            " Damage caused by cold sea water"
            + $" Player Stats || HP: {health -20 } || Mana:100 || " + "\n";

            promptList[4] = "What do you do?\n" + "\n"+
                            "a) Type \"Dive\" to find the a way into the cave underwater. \n";
            
            locationList[5] = "At this point, the only portal that is growing is in south direction. After jumping into the portal, it will fly you in a deep dense ancient forest." + "\n" 
            + " During the time of exploration for ancient artifact, you will find a 4000 years-old tree that is somewhat transform to a human like animal."+ "\n" 
            +"There will be item a book of the four ancient monsters that are defending the last ancient artifact. " + "\n" 
            + "\n" +"The book will comsume your HP by 50, so that in return it lead you to the ancient monsters"
            +"\n"+ $" Player Stats || HP: {health -70 } || Mana:100 || " + "\n"; health = ( health - 70 );

            promptList[5] = "You have transported back to the rock platform and you will be going to choose from four different portals to fight one of the final 4 ancient monsters."+"\n"+"Which location do you want to go."+"\n"
                            + "\n" + $" Player Stats || HP: {health} || Mana:100 || " + "\n"
                            + "\n"+ "a) Type \"NW\" to go the Snow Mountain." + "\n"+
                            "b) Type \"NE\" to go on the mountaintop of the flame mountain." + "\n"
                            + "c) Type \"SW\" to go to an Island on dark sea." + "\n"
                            + "d) Type \"SE\" to go over clouds" + "\n";

            locationList[6] = "You enter the portal in northeast which is a snowmountain where the White Tiger lives, lots of tree being bent by snow."+  "\n" +" Now, you encounter the White Tiger. " + "\n"
                              + $" Player Stats || HP: {health} || Mana:100 || " + "\n";

            promptList[6] = "What do you do?\n" + "\n"+
                            "a) Type \"Sword\" to fight the White Tiger. \n" + 
                            "b) Type \"Heal\"  to return to rock platform and get HP back to 100.";

            locationList[7] = "Vermilion bird have caught you and drop you into her nest which is a place located at the top edge of the flame mountain. Giving you no place to escape ..." + "\n"
             + $" Player Stats || HP: {health} || Mana:100 || " + "\n";

            promptList[7] = "What do you do?\n" + "\n"+
                            "a) Type \"Sniper\" to fight Vermilion Bird . \n" + 
                            "b) Type \"Heal\"  to return to rock platform and get HP back to 100.";

            locationList[8] = "You arrived on an Island on dark sea, " + "\n"
             + $" Player Stats || HP: {health} || Mana:100 || " + "\n";

            promptList[8] = "What do you do?\n" + "\n"+
                            "a) Type \"Torpedo\" to fight the Black Tortoise. \n" + 
                            "b) Type \"Heal\"  to return to rock platform and get HP back to 100.";

            locationList[9] = "You have been blew over to the Clouds." + "\n"
             + $" Player Stats || HP: {health} || Mana:100 || " + "\n";

            promptList[9] = "What do you do?\n" + "\n"+
                            "a) Type \"Air\" to call out air strike to fight the Azure Dragon . \n" + 
                            "b) Type \"Heal\"  to return to rock platform and get HP back to 100.";

            locationList[10] = "You have finished one of the ancient monster, Congradulations!!!!!!" + "\n" + 
                               "You have collect enough ancient artifacts." + "\n" + 
                               "Then you start to falling as the floating platform starts to broken down.";

            promptList[10] = "What do you do?\n" + "\n"+
                            "Type \"Close\" to close you eyes";
            
            locationList[11] = "Congradulations! Adventrue Completed!!!!! Thanks for playing";

            locationList[12] = "You have transported back to the rock platform and you will be going to choose from four different portals to fight one of the final 4 ancient monsters. Which location do you want to go."+"\n"
                            + $" Player Stats || HP: {health} || Mana:100 || " + "\n";
            
            promptList[12] = "Where do you want to go?\n" + "\n"+
                            "a) Type \"NW\" to go the Snow Mountain." + "\n"+
                            "b) Type \"NE\" to go on the mountaintop of the flame mountain." + "\n"
                            + "c) Type \"SW\" to go to an Island on dark sea." + "\n"
                            + "d) Type \"SE\" to go over clouds" + "\n";

            

        
            //gameover bool to exit the game
            bool gameOver = false;
            int locationIndex = 0;
            while (!gameOver)
            //Locations 
            {   Console.WriteLine(locationList[locationIndex]);

                Console.WriteLine(promptList[locationIndex]);


                string answer = Console.ReadLine();
                //Switch statment for different input from players and print different resutl of their choices.
                switch (answer){
                    case "North":{
                        Console.WriteLine("\n" + "You are entering the North Portal \n" + "\n" ) ;
                        locationIndex++;
                        break;
                    }
                    case "Cave":{
                        Console.WriteLine("\n" + "You walking into the cave with a sword, monster defeated. However the monster has wounded you" + "\n"+ $"Player Stats     || HP: {health -10} || Mana:100 ||    \n" + "\n");
                        locationIndex++;
                        break;    
                    }
                    case "Back":{
                        Console.WriteLine("\n" + "You are walking towards the north portal, the monster come outside the cave and ate you alive from behind.  \n" + "\n");
                        Console.WriteLine("You die because of your bad decision, try a better choice..." + "\n");
                        gameOver = true;
                        break;
                    }
                    case "Red":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 3;
                        break;
                    }
                    case "Blue":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 4;
                        break;
                    }
                    case "Run":{
                        Console.WriteLine("\n" + "You are running, the kid behind you is chasing you with a flamethrower, then you run into a dead end, no way to escape. " + "\n");
                        gameOver = true;
                        break;
                    }
                    case "Dive":{
                        Console.WriteLine("\n" + "You jump into the water and diving into the cave. You found the shining ancient artifact and carried by to the boat. " + "\n");
                        locationIndex = 5;
                        break;

                    }
                    case "NW":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 6;
                        break;

                    }
                    case "NE":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 7;
                        break;

                    }
                    case "SW":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 8;
                        break;

                    }
                    case "SE":{
                        Console.WriteLine("\n" + "Start transfering............." + "\n");
                        locationIndex = 9;
                        break;

                    }

                    case "Sword":{
                        Console.WriteLine("\n" + "swirling sword towards white tiger, the white tiger jumps up very high, but when it falls, you end the fight with your sword penetrating its body." + "\n");
                        locationIndex = 10;
                        break;

                    }

                    case "Sniper":{
                        Console.WriteLine("\n" + "You jump right off the cliff while You aiming in mid air, 3, 2, 1... Shot went right through its eyes." + "\n");
                        locationIndex = 10;
                        break;

                    }

                    case "Torpedo":{
                        Console.WriteLine("\n" + "Getting into the luancher, 3, 2, 1..... Pushed the button, target hit and defeat." + "\n");
                        locationIndex = 10;
                        break;

                    }

                    case "Air":{
                        Console.WriteLine("\n" + "Calling over air strikes, 3, 2, 1..... Planes starting droping bombs on Azue Dragon." + "\n");
                        locationIndex = 10;
                        break;

                    }
                    case "Close":{
                        Console.WriteLine("\n" + "All of a sudden, you wake up in your bed and holding all three ancient artifacts" + "\n");
                        locationIndex = 11;
                        break;
                    }
                    case "Heal": {
                        if(health <= 100 )
                        {
                            locationIndex = 12;
                            health = 100;
                            Console.WriteLine("\n" + "Insid the portal, You reach to your backpack for a healing potion. " + "\n" + $" Player Stats || HP: {health}|| Mana:100 || ");
                        }
                        else{
                            locationIndex = 5;
                            Console.WriteLine("\n" + "Insid the portal, You reach to your backpack for a healing potion. " + "\n" + $" Player Stats || HP: {health}|| Mana:100 || ");
                        }

                        break;
                    }
                    default:{
                        Console.WriteLine("\n" + "Bad option, you die \n");
                        Console.WriteLine("\n" + "You die because of your bad decision, try a better choice...");
                        gameOver = true;
                        break;
                    }
                }
                



                
            }

           

            
           


            
            



        }
    }
}


