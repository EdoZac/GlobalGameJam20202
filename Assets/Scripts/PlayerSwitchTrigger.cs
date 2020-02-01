using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitchTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Cube1"))
        {
            GameObject switchPlay = GameObject.FindWithTag("PlayerSwitch");
            DropdownTrigger dropDown = switchPlay.GetComponent<DropdownTrigger>();
            dropDown.isActive = true;
        }
    }
}

