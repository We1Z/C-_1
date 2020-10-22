// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{   
    //A class which uses inheritance(This is the child class)
    class HPpotion: Items
    {
        //properties
        private string Name { get;set; }
        

        //Constructor
        public HPpotion( int add = 50 )
        {


        }
       
        //Method
        public int increaseHP( int getHP )
        {
            int recovery = 100;
            getHP = recovery;
            return getHP;

        }
    }
}