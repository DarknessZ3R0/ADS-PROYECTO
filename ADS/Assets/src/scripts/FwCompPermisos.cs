using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FwCompPermisos : MonoBehaviour
{
    public Button BkPerm;
    // Start is called before the first frame update
    void Start()
    {
        BkPerm = BkPerm.GetComponent<Button>();
        BkPerm.onClick.AddListener(TaskOnClick);
    
    }

    void TaskOnClick(){
        SceneManager.LoadScene("CompletoPermisos");
    }
   
}
