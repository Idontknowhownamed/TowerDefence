using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public int speed;
    Vector2 touchstart;
    public float maxZoom, minZoom, sensivity;

    public float x, y;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            touchstart = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);        
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 direction = touchstart;
            GetComponent<Camera>().transform.position = direction;
        }
        ZoomCamera(Input.GetAxis("Mouse ScrollWheel"));

    }

    void ZoomCamera(float increment)
    {
        GetComponent<Camera>().orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize - increment * sensivity, minZoom, maxZoom);
    }

}
