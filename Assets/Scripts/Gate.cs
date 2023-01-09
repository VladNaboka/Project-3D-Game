using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int valueNum;
    [SerializeField] DefomationType defomationType;
    [SerializeField] GateController gateController;

    private void OnValidate()
    {
        gateController.Visual(defomationType, valueNum);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModification playerModification = other.attachedRigidbody.GetComponent<PlayerModification>();
        if (playerModification)
        {
            if (defomationType == DefomationType.Weight)
            {
                playerModification.WeightUp(valueNum);
            }
            else if (defomationType == DefomationType.Height)
            {
                playerModification.HeightUp(valueNum);
            }
            Destroy(gameObject);
        }
    }
}
