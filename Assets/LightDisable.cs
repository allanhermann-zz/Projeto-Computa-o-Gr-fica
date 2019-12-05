using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LightDisable : MonoBehaviour
{
    public Light myLight;

    private void OnTriggerEnter()
    {
        Debug.Log("Entrou na área do Trigger");
        myLight.enabled = !myLight.enabled;
    }

    private void OnTriggerExit()
    {
        Debug.Log("Saiu da área do Trigger");
    }


}
