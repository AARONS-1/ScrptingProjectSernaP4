using System.Collections;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class DualAxisExample : MonoBehaviour
{
    
    public float hrange;
    public float vrange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hrange;
        float yPos = h * vrange;

        transform.position = new Vector3(xPos, 0, yPos);
        Debug.Log(h.ToString("F2"));
        Debug.Log(v.ToString("F2"))
;    }
}
