using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electrifiedFloor : MonoBehaviour
{
    public GameController game;                            //a reference to the game controller script
    public bool alwaysElectrified = false;                 //if you want a floor pannel to always be electrified
    public bool neverElectrified = false;                  //if you want a floor pannel to never be electrified
    [HideInInspector] public bool isElectrifed = true;     //a boolean variable to check to see if a floor is electrified
    [HideInInspector] private float timer = 0f;            //a timer float to keep up with the time that has passed

    void Update()
    {
        //create and update the timer
        timer += Time.deltaTime;

        // if the floor is currently electrified
        if (isElectrifed)
        {
            //if the timer is greater than the amount of time the floor is supposed to be on
            if (timer > game.electrifiedFloorOnTime)
            {
                //if the floor tile is never supposed to be electrifed
                if (!alwaysElectrified)
                {
                    //set the electricity effect to be inactive
                    this.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                    isElectrifed = false;
                    //reset the timer
                    timer = 0.0f;
                }
            }

        }// if the floor is no longer electrifed
        else if (!isElectrifed)
        {
            //if the timer is greater than the amount of time the floor is supposed to be off
            if (timer > game.electrifiedFloorOffTime)
            {
                //if the floor tile is always supposed to be electrifed
                if (!neverElectrified)
                {
                    //set the electricity effect to be inactive
                    this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    isElectrifed = true;
                    //reset the timer
                    timer = 0.0f;
                }
            }
        }

    }

}
