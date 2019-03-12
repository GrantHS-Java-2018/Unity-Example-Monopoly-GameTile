using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameLoop : MonoBehaviour
{
    public GameTile[] gameTiles = new GameTile[8];
    //gameTiles[0] = new Free
    private void Start()
    {
        gameTiles[0].doThing();
    }
}
