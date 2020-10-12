// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{   
    class Location
    {
        //properties
        private string _description;

        /*public bool CanGoUp { get; private set; }
        public bool CanGoDown { get; private set; }
        public bool CanGoLeft { get; private set; }
        public bool CanGoRight { get; private set; }*/
        private Location[,] _gameMap;
        private int _mapMaxSize = 10;
        
        private string[,] promptList = new string[1,4];


        //Constructor
        public Location( string desc )
        {
            _description = desc;
        }
        public string Desc()
        { 
            return _description; 
        }
        /*public void SetAllowableDirection( bool up, bool down, bool left, bool right )
        {
            CanGoUp = up;
            CanGoDown = down;
            CanGoLeft = left;
            CanGoRight = right;
        }*/



    public Location LocationAt( int i, int j )
        {
            if ((i > _mapMaxSize) || (j > _mapMaxSize))
            return new Location("the abyss - you die!");

            return _gameMap[i, j];
        } 

        public string PromptDesc( int i, int j )
        {
            Location loc = LocationAt( i, j );
            return loc.Desc();
        }






    }

}