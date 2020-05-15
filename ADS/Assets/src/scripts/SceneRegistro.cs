using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneRegistro : MonoBehaviour
{
    // Start is called before the first frame update
    public Button MiBoton;
    void Start()
    {
        Button btn = MiBoton.GetComponent<Button>();
        
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick(){
        SceneManager.LoadScene("Registro_Scene");
    }
}
