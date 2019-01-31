using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController _instance;
    public static GameController instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameController>();

                //Tell unity not to destroy this object when loading a new scene!
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    //unity objects and transforms
    public GameObject player;                            //a reference to the player
    public GameObject mainCamera;                        //a reference to the main camera (not the one attached to the player)

    //Numerical values that will be used universally
    public float respawnTime = 2.5f;                     //how long it takes for the player to respawn
    public float electrifiedFloorOnTime = 5f;            //how long a floor stays electrified
    public float electrifiedFloorOffTime = 10f;          //how long a floor is no longer electrified


}
