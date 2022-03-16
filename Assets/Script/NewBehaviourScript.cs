using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class NewBehaviourScript : MonoBehaviour, IPointerClickHandler
{
    // public Image image;
        public Image image ;
        public string gameObjectName ;

        public void Awake()
        {
            image = GameObject.Find(gameObjectName).GetComponent<Image>();
          
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("aaaaaaaaaa");
            image.enabled = true;
            
        
        }

    // Start is called before the first frame update
    void Start()
    {
         image.enabled = false ;
       
    
    
    }

}
