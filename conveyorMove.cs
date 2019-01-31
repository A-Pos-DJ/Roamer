using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyorMove : MonoBehaviour
{
    public GameController game;                            //a reference to the game controller script
    public bool moveBackward = false;                      //if you want the conveyer belt to move the other way
    public float conveyorForce = 5f;                       //the speed at which the conveyer is moving the player

    void OnTriggerStay(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player"))
        {
            Rigidbody childRb = game.player.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();    //reference to the child object's rigidbody
            //if we are not moving backward
            if (!moveBackward)
            {
                //add forward force to the rigidbody
                game.player.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(transform.right * conveyorForce * 1000);
            }
            //if we are moving backward
            else if (moveBackward)
            {
                //add backward force to the rigidbody
                game.player.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(-transform.right * conveyorForce * 1000);
            }
        }
    }

}
