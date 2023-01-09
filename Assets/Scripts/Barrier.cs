using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject particlesBricks;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModification playerModification = other.attachedRigidbody.GetComponent<PlayerModification>();
        if (playerModification)
        {
            playerModification.Barrier();
            Destroy(gameObject);
            Instantiate(particlesBricks, transform.position, transform.rotation);
        }
    }
}
