using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerControllerMove playerControllerMove;
    [SerializeField] PreFinishBehaviour preFinishBehaviour;
    [SerializeField] Animator animator;
    private void Start()
    {
        playerControllerMove.enabled = false;
        preFinishBehaviour.enabled = false;
    }
    public void PlayBehavourButton()
    {
        playerControllerMove.enabled = true;
    }

    public void StartPreFinish()
    {
        playerControllerMove.enabled = false;
        preFinishBehaviour.enabled = true;
    }
    public void StartFinish()
    {
        preFinishBehaviour.enabled = false;
        animator.SetTrigger("Dance");
    }
}
