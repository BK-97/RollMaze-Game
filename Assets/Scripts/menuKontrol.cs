using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Play()
    {
            SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
