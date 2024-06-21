using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllDropRevolution 
{
    public RevolutionSkins Ak = new RevolutionSkins("Ak_HeadShot", 1500, "Red");

    public class RevolutionSkins
    {
         string nameSkin;
         float Price;
         string rarity;

        public RevolutionSkins(string name, float price, string rarity)
        {
             nameSkin = name;
             Price = price;
             this.rarity = rarity;
        }
    }
}
