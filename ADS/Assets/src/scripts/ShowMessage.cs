using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowMessage : MonoBehaviour
{   public GameObject mensaje;
    public Button guardar;

    // Start is called before the first frame update
    void Start()
    {
        guardar = guardar.GetComponent<Button>();
        guardar.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void TaskOnClick(){
        
            mensaje.SetActive(true);

        
    }
}
