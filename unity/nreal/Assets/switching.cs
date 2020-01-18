using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switching : MonoBehaviour
{
    public string level_name = "Input-ControllerInfo";
    public AudioSource a1;
    // public GameObject SphereToChange;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
   public void ChangeScene(){
        // SphereToChange.GetComponent<Renderer>().material.color = Color.red;
        Application.LoadLevel(level_name);
        
   }

   public void PlayBackgroundMusic(){
      a1.Play();
   }
    // Update is called once per frame
    void Update()
    {
        
    }
}
