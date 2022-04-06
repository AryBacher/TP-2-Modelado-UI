using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayorDe18 : MonoBehaviour
{
    public int edad;
    public Text Texto;

    // Start is called before the first frame update
    void Start()
    {
        if (edad >= 18)
        {
            Texto.text = "Usted es mayor de edad";
        }

        else
        {
            Texto.text = "Usted no es mayor de edad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
