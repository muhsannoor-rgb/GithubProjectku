using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerIntraction : MonoBehaviour
{
[SerializeField] private Animator FeixiaoDanceAnimator;

   private void OnTriggerEnter(Collider Other)
   {
        // if the other collider is the right Object

        // do something
        FeixiaoDanceAnimator.SetBool("isinteraction", true);
   }

   private void OnTriggerExit(Collider other)
   {
        FeixiaoDanceAnimator.SetBool("isinteraction", false);
   }
}
