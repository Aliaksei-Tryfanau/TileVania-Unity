using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] float SlowMotion = 0.2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine("LoadNextLevel");
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = SlowMotion;
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        Time.timeScale = 1f;
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
}
