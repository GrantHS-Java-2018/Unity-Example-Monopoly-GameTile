using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameLoop : MonoBehaviour
{

    [SerializeField] private GameObject _freeParking;    
   
    //create an array of GameTiles
    public GameTile[] gameTiles = new GameTile[8];

    public List<GameTile> gameTilesList;

    public List<GameObject> gameList;
    //gameTiles[0] = new Free
    private void Start()
    {
        gameList.Add(_freeParking);
        
        //gameTilesList.Add(new FreeParking());
        gameTilesList.Add(new Street("Boardwalk"));

        foreach (GameTile gameTile in gameTilesList)
        {
            Debug.Log(gameTile.name);
        }

        Debug.Log("YOYO" + (gameList[0].GetComponent<GameTile>().name));

    }
}
