﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SUMAYRESULTADO : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI txtResultado;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void Suma()
    {
        num1 = int.Parse(inputNum1.text);
        num2 = int.Parse(inputNum2.text);
        txtResultado.text = (num1 + num2) + "";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
