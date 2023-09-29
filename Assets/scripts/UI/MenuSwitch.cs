using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSwitch : MonoBehaviour
{
    [SerializeField] string mapScene;
    public AudioSource ClickSound;
    public GameObject MenuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMain()
    {
        SceneManager.LoadScene(mapScene);
        ClickSound.Play();
    }
    public void MenuOnPanel()
    {
        MenuPanel.SetActive(true);
        ClickSound.Play();
    }

}
