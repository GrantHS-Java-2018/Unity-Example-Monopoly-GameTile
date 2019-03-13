using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class FreeParking : GameTile
{

    public FreeParking()
    {
        name = "Free Parking";
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
