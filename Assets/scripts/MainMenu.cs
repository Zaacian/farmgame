using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string mapScene;
    public AudioSource ClickSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNewGame()
    {
        SceneManager.LoadScene(mapScene);
        ClickSound.Play();
    }
    public void ExitScence()
    {
        ClickSound.Play();
    }
}
