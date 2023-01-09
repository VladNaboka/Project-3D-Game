using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (playerBehaviour)
        {
            playerBehaviour.StartFinish();
            FindObjectOfType<CameraController>().activAnim = true;
            Destroy(gameObject);
            //FindObjectOfType<GameManager>().FinishUI();
        }
    }
}
