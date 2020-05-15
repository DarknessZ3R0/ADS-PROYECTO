using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;

public class SceneLogin : MonoBehaviour
{
    // Start is called before the first frame update
    public Button MiBoton;
    public InputField User_mail;
    public InputField User_password;
    public InputField User_id;
    public InputField User_birthday;
    //public GameObject mensaje;
  
    void Start()
    {
        Button btn = MiBoton.GetComponent<Button>();
        User_mail = User_mail.GetComponent<InputField>();
        User_password = User_password.GetComponent<InputField>();
        User_id = User_id.GetComponent<InputField>();
        User_birthday = User_birthday.GetComponent<InputField>();
        btn.onClick.AddListener(TaskOnClick);
    }
    //[MenuItem("Tools/Write file")]
     void WriteString()
     {
         string path = "Assets/src/scripts/Usuarios.txt";
         //string mail = User_mail.text.ToString();
         StreamWriter writer = new StreamWriter(path, true);
         writer.WriteLine(User_mail.text);
         writer.WriteLine(User_password.text);
         writer.WriteLine(User_id.text);
         writer.WriteLine(User_birthday.text);
         writer.Close();
     }
 
 //[MenuItem("Tools/Read file")]
   
    void TaskOnClick(){
        if((User_mail.text == "") && (User_password.text == "") && (User_id.text == "") && (User_birthday.text == "") ){
            //mensaje.SetActive(true);
            Debug.Log("No Entro");
        }else{
            WriteString();//check
            SceneManager.LoadScene("Home_Scene");
            //Debug.Log("Entro");
        }
       
        
    }
  
}
