using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manager : MonoBehaviour
{
    private static scene_manager _instance;
    public static scene_manager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    int MENU_IND = 0, LEVEL_IND = 1, END_IND = 2;
    int scene_ind;
    // Start is called before the first frame update
    void Start()
    {
        scene_ind = SceneManager.GetActiveScene().buildIndex;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        scene_ind = LEVEL_IND;
        SceneManager.LoadScene(scene_ind);
    }
    public void EndGame()
    {
        scene_ind = END_IND;
        SceneManager.LoadScene(scene_ind);
    }
    public void ReturnToMenu()
    {
        scene_ind = MENU_IND;
        SceneManager.LoadScene(scene_ind);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
