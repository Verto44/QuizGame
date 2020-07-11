using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoTheme : MonoBehaviour
{
    public int idTheme;

    public GameObject starOn01;
    public GameObject starOn02;
    public GameObject starOn03;

    private int finalGrade;


    // Start is called before the first frame update
    void Start()
    {
        starOn01.SetActive(false);
        starOn02.SetActive(false);
        starOn03.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
