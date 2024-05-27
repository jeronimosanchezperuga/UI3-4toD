using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    public InputField inputPassword;
    public string password = "manzana";

   public void CheckPassword()
    {
        if (inputPassword.text == password)
        {
            Debug.Log("Access granted");
        }
        else
        {
            Debug.Log("Access denied");
        }
    }
}
