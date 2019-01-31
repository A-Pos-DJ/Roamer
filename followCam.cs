using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour
{
    public GameController game;                            //a reference to the game controller script
    public float cameraDistanceY = 5f;                     //how far you want the camera to be away
    public float cameraDistanceZ = 7f;                     //how far you want the camera to be away


    // Update is called once per frame
    void Update ()
    {
        Transform pT = game.player.transform.GetChild(0).gameObject.transform;                // a reference to the player's transform
        this.gameObject.transform.position = new Vector3(pT.position.x, (pT.position.y + cameraDistanceY), (pT.position.z + cameraDistanceZ));   //move the position the camera to a distance away from the player
    }
}
