using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextLevel());
        
       
    }

    IEnumerator LoadNextLevel()
    {
       yield return new WaitForSecondsRealtime(levelLoadDelay);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


}
