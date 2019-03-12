using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeParking : GameTile
{
    public override void setPos()
    {
        pos = this.transform.position;
    }
    
    public override void doThing()
    {
        //Aint doin shoot
    }
}
