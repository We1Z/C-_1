// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{
    class player
    {
        ///Properties
        private int _mapSize = 0;
        private int locX;
        private int locY;


        //Constructor
        public player( int mapSize, string name = "Hunter" )
        {
            //_mapSize is a field 
            _mapSize = mapSize;
            //initialize all properties here
            locX = 0; 
            locY = 0;
        }

        public int LocX {
            get
            {
                return locX;
            } 
            set
            {
                locX = value;
                if (value <= 0) //location never smaller than 0
                    locX = 0;
                if (value > _mapSize)
                    locX = _mapSize;
            }
        }

        public int LocY {get
            {
                return locY;
            } 
            set
            {
                locY = value;
                if (value <= 0) //location never smaller than 0
                    locY = 0;
                if (value > _mapSize) //Location never bigger than the size of the map
                    locY = _mapSize;
            
            }
        }


        
        
        //Methods
        public void Update()
        {
            //TODO update the player's location??
            string answer = GetPlayerAction("");



            
        }

        public string GetPlayerAction(string answer)
        {
            return answer;
        }



    }
}