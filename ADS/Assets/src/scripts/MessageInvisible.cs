using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MessageInvisible : MonoBehaviour
{
    public GameObject mensaje;
    public Button ok;
    // Start is called before the first frame update
    void Start()
    {
        ok = ok.GetComponent<Button>();
        ok.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void TaskOnClick(){
        mensaje.SetActive(false);
    }
}
