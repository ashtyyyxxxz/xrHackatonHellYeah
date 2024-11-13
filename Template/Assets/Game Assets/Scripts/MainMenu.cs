using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartLoadScene(int sceneIndex)
    {
        audioSource.Play();
        
        SceneManager.LoadScene(sceneIndex);
    }
    public void ExitApplication()
    {
        audioSource.Play();
        Application.Quit();
    }
}
