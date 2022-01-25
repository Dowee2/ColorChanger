using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Vector3 scaleChange;
    private int growCount;
    public Material color;


    // Start is called before the first frame update
    void Start()
    {
        growCount = 0;
        scaleChange = new Vector3(1, 1, 1);
        color = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("Colors"))
        {
           gameObject.transform.localScale = new Vector3(1, 1, 1);
        }

        if (growCount < 10)
        {
            transform.localScale += scaleChange * growCount/2;
            growCount++;
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
            growCount = 0;
        }

        foreach (GameObject gameObject in GameObject.FindGameObjectsWithTag("ChangeMe"))
        {
            Renderer renderer = gameObject.GetComponent<Renderer>();
            renderer.material = color;
        }
    }
}
