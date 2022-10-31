using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFloorAnim : MonoBehaviour
{
    [SerializeField] private Animator floorAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            floorAnimationController.SetBool("PlayAnimation", true);
        }
    }
 
}
