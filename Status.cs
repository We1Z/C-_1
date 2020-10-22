// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{   
    class Status
    {
        //properties
        private int Health{ get;set; }
        private int Damage{ get;set; }
       
        

        //Constructor
        public Status( int health = 100 )
        {
            Health = health;
        }
        //Overload method for getting damage from monster when input two parameter when calling the construtor
        public Status(int health = 100 , int damage = 10)
        {
            Health = health - damage;
        }
        //Method
        
        public int HPcheck ()
        {
            int health = 100;
            return health; 
        }
        
        public bool HPdecrease( bool gameState)
        {
            bool gameover = gameState;
            int HP =  HPcheck();
            if( HP == 0 )
            {
                gameState = true;
            }
            return gameover;  
        }


        public void HPincrease()
        {

        }

    }
}