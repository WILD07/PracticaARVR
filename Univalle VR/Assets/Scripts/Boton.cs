﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton : MonoBehaviour {

    public void PasarVR()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
