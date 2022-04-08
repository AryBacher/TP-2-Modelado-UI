using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñaCorrecta;
    string contraseñaUsuario;
    public Text textomsj;
    public Text ingresadoUsuario;
    public GameObject msjBox;
    // Start is called before the first frame update
    void Start()
    {
        msjBox.SetActive(false);
        contraseñaCorrecta = "abc123";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ValidarContrasenia()
    {
        contraseñaUsuario = ingresadoUsuario.text;

        if (contraseñaUsuario == contraseñaCorrecta)
        {
            msjBox.SetActive(true);
            textomsj.text = "Contraseña Correcta. Bienvenido!";
            Debug.Log("Contraseña Correcta. Bienvenido!");
        }

        else
        {
            msjBox.SetActive(true);
            textomsj.text = "Contraseña Incorrecta. Por favor, ingrese su contraseña correctamente";
            Debug.Log("Contraseña Incorrecta. Por favor, ingrese su contraseña correctamente");
        }
    }
}
