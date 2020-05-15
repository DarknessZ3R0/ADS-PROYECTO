using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLogin : MonoBehaviour
{
    // Start is called before the first frame update
    public Button MiBoton;
    public InputField User_mail;
    public InputField User_password;
    public InputField User_id;
    public InputField User_birthday;
    
    void Start()
    {
        Button btn = MiBoton.GetComponent<Button>();
        User_mail = User_mail.GetComponent<InputField>();
        User_password = User_password.GetComponent<InputField>();
        User_id = User_id.GetComponent<InputField>();
        User_birthday = User_birthday.GetComponent<InputField>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
        
        SceneManager.LoadScene("Home_Scene");
        
    }
  
}
