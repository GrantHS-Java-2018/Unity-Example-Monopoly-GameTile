using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameTile : MonoBehaviour
{
    public Vector3 pos;
    public string name;
    public abstract void doThing();

    public Vector3 getPos()
    {
        return pos;
    }

    public abstract void setPos();
}
