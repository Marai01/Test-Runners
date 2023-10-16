using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    void Start()
    {
        Object.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Object.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
