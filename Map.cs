// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{
    class Map
    {
        //properties
        private Location[,] _gameMap;
        private int _mapMaxSize = 10;

        
        //Constructor
        public Map( int mapSize )
        {
            if( mapSize < 1)
            return;

            _mapMaxSize = mapSize;
            _gameMap = new Location[ mapSize, mapSize ];
        }

        //Public Method
        public void Init()
        {
            //add the new location object to the map.
            //Setting which way you can go for all locations
            _gameMap[0,0] = new Location( "\nYou have entered a floating world, " +"there is a massive floating doughnut-shape rock platform located above the sky " + "\n"+ "The bottom of the platform is raw magnetic material look very artificial but broken.\n" + "\n"+ "There is only one growing portal in north direction, there are also seven other portals " + "surrounds the edge of this floating platform.\n" );
            _gameMap[0,1] = new Location( "Through the north portal, you have enter a blizzard world with mythical creature's cave,\n"+"\n"+ "Now, you are approaching the cave \n"+ "\n"+ "The snowstorming is blowing right into your face. \n" );
            _gameMap[0,2] = new Location( "Then after transfer back to the rock platform, two of the portals in west and east direction starting to grow in red and blue color\n"+"\n"+"\n" );
            _gameMap[0,3] = new Location( "The red growing portal in the west will lead to an area with a huge flame mountain, there is a kid that is the cause of all the fire in the area. Fire is all over the mountain. Heat damage caused by fire");
            _gameMap[0,4] = new Location( "Heading towards the East portal, it will get you on a boat on a dark sea area. The old man on the boat told you that by diving into a cave underneath the water will get you an ancient artifact." + " Damage caused by cold sea water");
            _gameMap[1,0] = new Location( "At this point, the only portal that is growing is in south direction. After jumping into the portal, it will fly you in a deep dense ancient forest." + "\n" + " During the time of exploration for ancient artifact, you will find a 4000 years-old tree that is somewhat transform to a human like animal."+ "\n" +"There will be item a book of the four ancient monsters that are defending the last ancient artifact. " + "\n" + "\n" +"The book will comsume your HP by 50, so that in return it lead you to the ancient monsters");
            _gameMap[1,1] = new Location( "You enter the portal in northwest which is a snowmountain where the White Tiger lives, lots of tree being bent by snow."+  "\n" +" Now, you encounter the White Tiger. " + "\n");
            _gameMap[1,2] = new Location( "Vermilion bird have caught you and drop you into her nest which is a place located at the top edge of the flame mountain. Giving you no place to escape ..." + "\n");
            _gameMap[1,3] = new Location( "You arrived on an Island on dark sea, " + "\n");
            _gameMap[1,4] = new Location( "You have been blew over to the Clouds." + "\n");
            _gameMap[2,0] = new Location( "You have finished one of the ancient monster, Congradulations!!!!!!" + "\n" + "You have collect enough ancient artifacts." + "\n" + "Then you start to falling as the floating platform starts to broken down."+ "\n" + "----------GAMEOVER---------");
        }


        public Location LocationAt( int i, int j )
        {
            if ((i > _mapMaxSize) || (j > _mapMaxSize))
            return new Location("the abyss - you die!");

            return _gameMap[i, j];
        } 

        public string DescAt( int i, int j )
        {
            Location loc = LocationAt( i, j );
            return loc.Desc();
        }

    }
}