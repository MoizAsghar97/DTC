using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

     public void DoorFirst()
     {
        SceneManager.LoadScene("New Scene2");
    }

    public void DoorThird()
     {
        SceneManager.LoadScene("New Scene2");
    }

    public void DoorFour()
     {
        SceneManager.LoadScene("New Scene2");
    }


}
