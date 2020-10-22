// Copyright (c) 2020 Wei Zeng, All Rights Reserved.
using System;

namespace Adventure
{
    class Game
    {
        public const int MAP_SIZE = 10;
        //properties(local Variables private)
        private bool _gameOver = false;
        private Location _currentLocation = new Location("The Begining");
        
        private player _player = new player( MAP_SIZE );
        private Map _theGameMap = new Map ( MAP_SIZE );
        private PromptList _theGamePrompt = new PromptList( MAP_SIZE );
        private Status _playerStatus = new Status( 100 );
        
    
        //private string[,] promptList = new string[1,4];

        //constructor
        public Game()
        {
            //create the map
            //initialize the game map
            _theGameMap.Init();
            _theGamePrompt.InitPrompt();
            
        
        }

        //Method
        public void Run()
        {
            welcomePlayer();
            Render();
            while (!_gameOver)
            {
                Update();
                Render();
            }
        }

        private void Update()
        {
            // update the _currentLocation here based on user input
            
    
            
            //collect user input
            _gameOver = HandleAnswer( _gameOver );

            //Condition for game over at zero HP
            
            _gameOver =_playerStatus.HPdecrease(_gameOver);
            
            
            //update player state
            //_player.Update(x, y);
            //Console.WriteLine("");
                


        }

        private void Render()
        {

            //use the _currentLocation to show the description
            //display locaiton
            Console.WriteLine( _theGameMap.DescAt( _player.LocX, _player.LocY ) ); 
            Console.WriteLine( "PLAYER STATS "+ "|| HP:" + _playerStatus.HPcheck() + " ||" + "\n");
            Console.WriteLine( _theGamePrompt.DescAt( _player.LocX, _player.LocY ) );             
            //Give player a health status
            
            
            

        }

        static void welcomePlayer()
            {
            Console.WriteLine("Hello, welcome to Adventure!" + "\n");
            Console.WriteLine("What is your name?" + "\n");
            string name =Console.ReadLine();
            Console.WriteLine("\n" + $"Hello, {name}! Welcome to your adventure......"+ "\n");
            }


        //Handle player aciton
        private bool HandleAnswer( bool gameState)
        {
            bool gameOver = gameState;
            //handle answer
             //User options
            
            string answer = Console.ReadLine( );
            //Switch statment for different input from players and print different resutl of their choices.
            switch (answer.ToLower())
            {
                case "north":{
                            Console.WriteLine("\n" + "You are entering the North Portal \n" + "\n" ) ;
                            _player.LocY = 1;
                            break;
                            }
                case "cave":{
                            Console.WriteLine("\n" + "You walking into the cave with a sword, monster defeated. However the monster has wounded you" + "\n"+ $"Player Stats     || HP:100 || Mana:100 ||    \n" + "\n");
                            _player.LocY = 2;
                            break;    
                            }
                case "back":{
                            Console.WriteLine("\n" + "You are walking towards the north portal, the monster come outside the cave and ate you alive from behind.  \n" + "\n");
                            Console.WriteLine("You die because of your bad decision, try a better choice..." + "\n");
                            _player.LocY = 0;
                            break;
                            }
                case "red":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocY = 3;
                            break;
                            }
                case "blue":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocY = 4;
                            break;
                            }
                case "run":{
                            Console.WriteLine("\n" + "You are running, the kid behind you is chasing you with a flamethrower, then you run into a dead end, no way to escape. " + "\n");
                            gameState =true;
                            break;
                            }
                case "dive":{
                            Console.WriteLine("\n" + "You jump into the water and diving into the cave. You found the shining ancient artifact and carried by to the boat. " + "\n");
                            _player.LocX = 1;
                            _player.LocY = 0;
                            break;

                            }
                case "nw":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocX = 1;
                            _player.LocY = 1;
                            break;

                            }
                case "ne":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocX = 1;
                            _player.LocY = 2;
                            break;

                            }
                case "sw":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocX = 1;
                            _player.LocY = 3;
                            break;

                            }
                case "se":{
                            Console.WriteLine("\n" + "Start transfering............." + "\n");
                            _player.LocX = 1;
                            _player.LocY = 4;
                            break;

                            }

                case "sword":{
                            Console.WriteLine("\n" + "swirling sword towards white tiger, the white tiger jumps up very high, but when it falls, you end the fight with your sword penetrating its body." + "\n");
                            _player.LocX = 2;
                            _player.LocY = 0;
                            break;

                            }

                case "sniper":{
                            Console.WriteLine("\n" + "You jump right off the cliff while You aiming in mid air, 3, 2, 1... Shot went right through its eyes." + "\n");
                            _player.LocX = 2;
                            _player.LocY = 0;
                            break;

                            }

                case "torpedo":{
                            Console.WriteLine("\n" + "Getting into the luancher, 3, 2, 1..... Pushed the button, target hit and defeat." + "\n");
                            _player.LocX = 2;
                            _player.LocY = 0;
                            break;

                            }

                case "air":{
                            Console.WriteLine("\n" + "Calling over air strikes, 3, 2, 1..... Planes starting droping bombs on Azue Dragon." + "\n");
                            _player.LocX = 2;
                            _player.LocY = 0;
                            break;

                            }
                case "close":{
                            Console.WriteLine("\n" + "All of a sudden, you wake up in your bed and holding all three ancient artifacts" + "\n");
                            gameOver =true;
                            break;
                            }
                case "heal": {
                            Console.WriteLine("\n" + "Insid the portal, You reach to your backpack for a healing potion. " + "\n" + $" Player Stats || HP:100 || Mana:100 || ");
                            _player.LocX = 1;
                            _player.LocY = 0;
                            break;
                            }
                case "exit": {
                            Console.WriteLine("You want to leave now?");
                            gameOver = true;
                            break;
                            }
                default:    {
                            Console.WriteLine("\n" + "Bad option, you die \n");
                            Console.WriteLine("\n" + "You die because of your bad decision, try a better choice...");
                            gameOver = true;
                            break;
                            }
            }
                //output my current state line
                return gameOver;
        }
    }

        
    }


