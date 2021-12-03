using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float changeSpeed = 0.01f;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        Material material = Renderer.material;
        material.color = new Color(
            (material.color.r + changeSpeed) % 1.0f,
            (material.color.g + changeSpeed) % 1.0f,
            (material.color.b + changeSpeed) % 1.0f,
            (material.color.a + changeSpeed) % 1.0f);

        Debug.Log(material.color.r);
    }
}
