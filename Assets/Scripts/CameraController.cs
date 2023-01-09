using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;

    [SerializeField] Quaternion rotationFinishCamera;
    public bool activAnim;
    private void Start()
    {
        transform.parent = null;
    }
    private void LateUpdate()
    {
        if (player)
        {
            transform.position = player.position;
        }
        if (activAnim)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rotationFinishCamera, 2 * Time.deltaTime);
            StartCoroutine(UIFinish());
        }
        
    }
    IEnumerator UIFinish()
    {
        yield return new WaitForSeconds(3f);
        FindObjectOfType<GameManager>().FinishUI();
    }
}
