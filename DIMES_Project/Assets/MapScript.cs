using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {

        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "start")
        {
            SceneManager.LoadScene("Map1");
        }
        if (sceneName == "Map1")
        {
            SceneManager.LoadScene("Level1");
        }
        if (sceneName == "Map2")
        {
            SceneManager.LoadScene("Level2");
        }
        if (sceneName == "Map3")
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
