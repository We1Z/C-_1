// Copyright (c) 2020 Wei Zeng, All Rights Reserved.

using System;

namespace Adventure
{   
    //A class which uses inheritance(This is the child class)
    class Weapon : Items
    {
        //properties
        private string Name { get;set; }
        private string Usesage { get;set; }
        private int Damage { get; set ; }

        //Constructor
        public Weapon( string name = "Sword", int damage = 10, string usesage = "Killing")
        {
            Name = name;
            Damage = damage;
            Usesage = usesage;
            
        }
       
        //Method

    }
}