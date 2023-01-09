using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject playButtons;
    [SerializeField] GameObject finishMenu;
    [SerializeField] TextMeshProUGUI nameLevels;
    [SerializeField] CoinManager _coinManager;
    private void Start()
    {
        nameLevels.text = SceneManager.GetActiveScene().name;
    }
    public void Play()
    {
        playButtons.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().PlayBehavourButton();
    }
    public void FinishUI()
    {
        finishMenu.SetActive(true);
    }
    public void NextLevel()
    {
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevel < SceneManager.sceneCountInBuildSettings)
        {
            _coinManager.SaveProgress();
            SceneManager.LoadScene(nextLevel);
        }

    }

}
