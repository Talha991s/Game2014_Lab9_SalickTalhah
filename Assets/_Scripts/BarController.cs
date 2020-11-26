using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BarController : MonoBehaviour
{
    public Transform bar;
    public Transform entity;
    public int currentvalue;
    public int maxValue;

    // Start is called before the first frame update
    void Start()
    {
        currentvalue = 100;
        maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(entity!=null)
        {
            transform.position = entity.position + Vector3.up;
        }
        
    }

    public void SetValue(int new_Value)
    {
        currentvalue = new_Value;
        bar.localScale = new Vector3((float)((double) currentvalue / (double)maxValue), 1.0f, 1.0f);


        // clamp the local scale to be zero minimum
        if(bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0.0f, 1.0f, 1.0f);
        }
    }
}
