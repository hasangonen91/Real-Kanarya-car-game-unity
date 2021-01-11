using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arac_degis : MonoBehaviour
{

    public GameObject araba1;
    public GameObject araba2;
    public GameObject panel;


    // Start is called before the first frame update
    void Start()//oyun basladıgı zaman calısacak kodlar
    {
        araba1.SetActive(false);
        araba1.SetActive(false);
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void araba_1button()
    {
        araba1.SetActive(true);
        araba2.SetActive(false);
        panel.SetActive(false);
    }
    public void araba_2button()
    {
        araba1.SetActive(false);
        araba2.SetActive(true);
        panel.SetActive(false);
    }
}
