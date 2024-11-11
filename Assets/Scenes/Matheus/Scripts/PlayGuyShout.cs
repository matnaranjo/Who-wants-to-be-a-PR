using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] AudioSource whoWantsToBeAPR;
    [SerializeField] AudioSource cheer;
    [SerializeField] float howEarlyTheGuySaysWhoWantsToBeAPR;


    // Start is called before the first frame update
    void Start()
    {
        whoWantsToBeAPR.PlayDelayed(howEarlyTheGuySaysWhoWantsToBeAPR);
        cheer.PlayDelayed(howEarlyTheGuySaysWhoWantsToBeAPR + 1);
    }

}
