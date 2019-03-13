using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street : GameTile
{
    
    public List<int> propVal { get; set; }

    public int condition
    {
        get
        {
            if (propVal.Count == 3)
            {
                return 3;
            }
            
            
            return 0;
            
        }   
    }

    public int numOfHouses;

    public int Value
    {
        get
        {
            switch (numOfHouses)
            {
                case 0:
                    return 345;
            }
        }
        
    }

    public bool hellYeah => (condition == 3);


    public Street(string nameOfStreet)
    {
        name = nameOfStreet;
    }
    
    public override void setPos()
    {
        pos = this.transform.position;
    }

    public override void doThing()
    {
        //Aint doin shoot
    }
    
    
}
