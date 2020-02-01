using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownTrigger : MonoBehaviour
{
    public bool isActive = false;
    public Animator animator;
    public Animation animation;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player") && isActive)
        {
            //animator.SetTrigger("DropDown");
            animation.Play();
        }
    }
}
