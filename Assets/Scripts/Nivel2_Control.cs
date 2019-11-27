using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel2_Control : MonoBehaviour
{
    public List<Toggle> abecedario;
    public List<GameObject> fondos;

    public void Update()
    {
        juego();

        if (fondos[0] == true && fondos[1] == true && fondos[2] == true && fondos[3] == true && fondos[4] == true)
        {
            Scene_Controller.NextLevel();
        }
    }

    public void juego()
    {
        if (abecedario[22].isOn == false)
        {
            fondos[0].SetActive(true);
        }
        if (abecedario[4].isOn == false)
        {
            fondos[1].SetActive(true);
            //if (abecedario[4].isOn == true)
            //{
            //    fondos[4].SetActive(true);
            //}
        }
        if (abecedario[18].isOn == false)
        {
            fondos[2].SetActive(true);
        }
        if (abecedario[3].isOn == false)
        {
            fondos[3].SetActive(true);
        }
    }



}
