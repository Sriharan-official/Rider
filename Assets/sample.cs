using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class sample : MonoBehaviour
{

    [SerializeField] [Range(0f, 1f)] float lerptime; // or = 0.5f
    public Color[] mycolors;
    int colorindex = 0;
    float t = 0f;
    public int len;
    public SpriteRenderer sp;
    private void Start()
    {
        len = mycolors.Length;    }
    void Update()
    {
        sp.color = Color.Lerp(sp.color, mycolors[colorindex], lerptime * Time.deltaTime);
       
        
        t = Mathf.Lerp(t, 1f, lerptime * Time.deltaTime);
        

        
        if(t>.9f)
        {
            t = 0f;
            colorindex++;
            colorindex = (colorindex >= len) ? 0 : colorindex;
        }
    }
}
