
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MydoorTrigger : MonoBehaviour
{
    public GameObject DoorLeftReference;
    public GameObject DoorRightReference;
    public bool doorIsOpen = false;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(doorIsOpen);        

        if (doorIsOpen == true)
        {
            doorIsOpen = false;
            DoorLeftReference.GetComponent<Animator>().SetTrigger("onDoorOpen");
            DoorRightReference.GetComponent<Animator>().SetTrigger("onDoorOpen");

        }
        else
        {
            DoorLeftReference.GetComponent<Animator>().SetTrigger("onDoorClose");
            DoorRightReference.GetComponent<Animator>().SetTrigger("onDoorClose");
        }

    }
}