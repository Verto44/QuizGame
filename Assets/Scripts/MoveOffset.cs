using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Renderer))]
public class MoveOffset : MonoBehaviour
{

    [Header("Velocidade do backgound scroll")]
    [Tooltip("Controla a velocidade do scroll")]
    [Space(8)]
    public float vel = 0.1f;    //Velocidade de deslocamento

    public Renderer quad;       //Objeto 3D do tipo Quad

    // Start is called before the first frame update
    void Start()
    {
        if(quad == null)
        {
            print("Entrou");
            quad = gameObject.GetComponent<MeshRenderer>();
        }

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(vel * Time.deltaTime, 0);
        quad.material.mainTextureOffset  += offset;

    }
}
