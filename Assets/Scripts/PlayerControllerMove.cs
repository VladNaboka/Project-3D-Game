using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMove : MonoBehaviour
{
    [SerializeField] private float speedPlayer;
    private float oldPosition;
    private float deltaY;
    [SerializeField] Animator animator;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldPosition = Input.mousePosition.x;
            animator.SetBool("Run", true);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * speedPlayer;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - oldPosition;
            oldPosition = Input.mousePosition.x;

            deltaY += deltaX;

            deltaY = Mathf.Clamp(deltaY, -60f, 60f);
            transform.eulerAngles = new Vector3(0, deltaY, 0);
        }
        else
            animator.SetBool("Run", false);

    }
}
