using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public bool black = false;
    public Button MiBoton;
    //public GameObject image;
    public Image image;
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
    public void changeColor(Image img ){
        
        //Color col = 
        if(black == false){
            
            img.color = Color.black;
            black = true;
        }else{
            black = false;
            img.color = Color.white;
        }
    
    }
    void TaskOnClick(){
        Image img = image.GetComponent<Image>();
        changeColor(img);
    }
}
