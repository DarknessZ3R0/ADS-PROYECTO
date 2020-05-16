using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Capacidad_subasta : MonoBehaviour
{
    public Text capacidad;
    public int total_alumnos_inscritos= 0;
    // Start is called before the first frame update
    void Start()
    {
        capacidad = gameObject.GetComponent<Text>();
        capacidad.text =total_alumnos_inscritos+"/20";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
