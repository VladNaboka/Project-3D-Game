using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModification : MonoBehaviour
{
    [SerializeField] int weight;
    [SerializeField] int height;

    float weightMultiplier = 0.0005f;
    float heightMultiplier = 0.01f;

    [SerializeField] Renderer rendererPlayer;

    [SerializeField] Transform topSpine;
    [SerializeField] Transform bottomSpine;

    [SerializeField] Transform colliderTransform;

    [SerializeField] AudioSource audioPump;
    private void Start()
    {
        SetHeight(Progres.Instance.Height);
        SetWight(Progres.Instance.Wight);
    }
    void Update()
    {
        float offsetY = height * heightMultiplier + 0.17f;
        topSpine.position = bottomSpine.position + new Vector3(0, offsetY, 0);
        colliderTransform.localScale = new Vector3(1, 1.8f + height * heightMultiplier, 1);

        if (Input.GetKeyDown(KeyCode.E))
            WeightUp(20);
        if (Input.GetKeyDown(KeyCode.T))
            HeightUp(20);
    }
    public void WeightUp(int value)
    {
        weight += value;
        UpdateWeight();
        if (value > 0)
            audioPump.Play();
    }
    public void HeightUp(int value)
    {
        height += value;
        if (value > 0)
            audioPump.Play();
    }
    public void SetWight(int value)
    {
        weight += value;
        UpdateWeight();
    }
    public void SetHeight(int value)
    {
        height += value;
    }
    void UpdateWeight()
    {
        rendererPlayer.material.SetFloat("_PushValue", weight * weightMultiplier);
    }
    public void Barrier()
    {
        if (weight > 0)
        {
            weight -= 50;
        }
        else if (height > 0)
        {
            height -= 50;
            UpdateWeight();
        }
        else
        {
            Die();
        }
    }
    void Die()
    {
        FindObjectOfType<GameManager>().FinishUI();
        Destroy(gameObject);
    }
}
