using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 15.0f;
    public float scaleValue = 1.5f;
    void Start()
    {
        transform.position = new Vector3(5, 4, 0);
        transform.localScale = Vector3.one * scaleValue;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
       
    }
    
    void Update()
    {
        transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f);
    }

}
