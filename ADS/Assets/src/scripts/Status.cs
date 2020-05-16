using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    
    public int iUser;
    // Start is called before the first frame update
    void Start()
    {
       
        iUser = PlayerPrefs.GetInt("Usuario");
        if(iUser == 1){
            Debug.Log("Alumno");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
