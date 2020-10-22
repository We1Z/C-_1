// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{   
    class PromptList
    {
        //properties
        private Location[,] _gamePrompt;
        //getting a HP status for player
        private Status _playerStatus;
        private int _mapMaxSize = 10;

        
        //Constructor
        public PromptList( int mapSize )
        {
            if( mapSize < 1)
            return;

            _mapMaxSize = mapSize;
            _gamePrompt = new Location[ mapSize, mapSize ];
        }
        public void InitPrompt()
        {
            _gamePrompt[0,0] = new Location( "What do you do?\n" + "\n"+"a) Type \"North\" to walk in to the north portal. \n");
            _gamePrompt[0,1] = new Location("What do you do?\n" + "\n"+"a) Type \"Cave\" to Enter the cave kill the monster inside....\n" + "b) Type \"Back\" to Walk back to the portal\n" );
            _gamePrompt[0,2] = new Location("What do you do?\n" + "\n"+ "a) Type \"Red\" to go into the West Portal. \n" +  "b) Type \"Blue\" to Go into the East Portal. \n");
            _gamePrompt[0,3] = new Location("What do you do?\n" + "\n"+ "a) Type \"Run\" to find the a way out of the situation. \n");
            _gamePrompt[0,4] = new Location("What do you do?\n" + "\n"+ "a) Type \"Dive\" to find the a way into the cave underwater. \n");
            _gamePrompt[1,0] = new Location("You have transported back to the rock platform and you will be going to choose from four different portals to fight one of the final 4 ancient monsters."+"\n"+"Which location do you want to go."+"\n" +  "\n" + "\n"+ "a) Type \"NW\" to go the Snow Mountain." + "\n"+"b) Type \"NE\" to go on the mountaintop of the flame mountain." + "\n"+ "c) Type \"SW\" to go to an Island on dark sea." + "\n"+ "d) Type \"SE\" to go over clouds" + "\n");
            _gamePrompt[1,1] = new Location("What do you do?\n" + "\n"+"a) Type \"Sword\" to fight the White Tiger. \n" + "b) Type \"Heal\"  to return to rock platform and get HP back to 100.");
            _gamePrompt[1,2] = new Location("What do you do?\n" + "\n"+"a) Type \"Sniper\" to fight Vermilion Bird . \n" + "b) Type \"Heal\"  to return to rock platform and get HP back to 100.");
            _gamePrompt[1,2] = new Location("What do you do?\n" + "\n"+"a) Type \"Torpedo\" to fight the Black Tortoise. \n" + "b) Type \"Heal\"  to return to rock platform and get HP back to 100.");
            _gamePrompt[1,3] = new Location("What do you do?\n" + "\n"+"a) Type \"Air\" to call out air strike to fight the Azure Dragon . \n" + "b) Type \"Heal\"  to return to rock platform and get HP back to 100.");
            _gamePrompt[1,4] = new Location("What do you do?\n" + "\n"+ "Type \"Close\" to close you eyes");
            _gamePrompt[2,0] = new Location("Nice Work!!!");
        }

        public Location LocationAt( int i, int j )
        {
            if ((i > _mapMaxSize) || (j > _mapMaxSize))
            return new Location("the abyss - you die!");

            return _gamePrompt[i, j];
        } 

        public string DescAt( int i, int j )
        {
            Location loc = LocationAt( i, j );
            return loc.Desc();
        }


    }

}