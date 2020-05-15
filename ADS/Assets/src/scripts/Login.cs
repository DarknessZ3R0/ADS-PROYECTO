using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.IO;
public class Login : MonoBehaviour
{
    public InputField User_mail;
    public InputField password;
    public Button login;
    public GameObject mensaje;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = login.GetComponent<Button>();
        User_mail = User_mail.GetComponent<InputField>();
        password = password.GetComponent<InputField>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void ReadString(){
         bool mail =false;
         bool pssw = false;

         string cmp;
        string path = "Assets/src/scripts/Usuarios.txt";
         //Read the text from directly from the test.txt file
         StreamReader reader = new StreamReader(path); 
         
         do{
             cmp = reader.ReadLine();
             if(cmp == User_mail.text){
                 mail =true;
                cmp = reader.ReadLine();
                if(cmp == password.text){
                    pssw = true;
                    break;
                }   
             }else{
                 Debug.Log("No encontrado");
             }
         }while(cmp != null);
         if(mail == true && pssw == true){
            
         }else{
            
         }
         reader.Close();
         
     }
    void TaskOnClick(){
        if((User_mail.text == "") && (password.text == "")){
            mensaje.SetActive(true);
        }else{
            //implementar el read de algun archivo y una busqueda de 
            //usuarios para validar el login, No es muy necesario 
            //pero quedaria mamalon xD
            //SceneManager.LoadScene("ApplicationScene");
            //ReadString();
            SceneManager.LoadScene("ApplicationScene");
        }
       
        
    }
}
