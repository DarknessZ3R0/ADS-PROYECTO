using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cancelar : MonoBehaviour
{
    public Button MiBoton;
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = MiBoton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void TaskOnClick(){
        
        SceneManager.LoadScene("Home_Scene");
        
    }
}
