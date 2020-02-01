using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDoorTrigger : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Cubo2"))
        {
            animator.SetTrigger("LaserDeactivation");
        }
    }
}
