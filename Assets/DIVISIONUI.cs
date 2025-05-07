using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DIVISIONUI : MonoBehaviour
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
    public void Division()
    {
        //Hacer un IF para que el input no sea 0
        num1 = int.Parse(inputNum1.text);
        num2 = int.Parse(inputNum2.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
