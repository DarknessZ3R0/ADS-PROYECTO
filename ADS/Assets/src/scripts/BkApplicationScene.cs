using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BkApplicationScene : MonoBehaviour
{
    public Button L0gout;
    // Start is called before the first frame update
    void Start()
    {
        L0gout = L0gout.GetComponent<Button>();
        L0gout.onClick.AddListener(TaskOnClick);
    
    }

    void TaskOnClick(){
        SceneManager.LoadScene("ApplicationScene");
    }
   
}
