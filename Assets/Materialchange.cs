using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Materialchange : MonoBehaviour
{
    
    [SerializeField][Range(0f, 1f)] float lerptime; // or = 0.5f
    
    public SpriteRenderer sp;
    public Material[] mat1;
    public int len;
    float t = 0f;
    int mat2 = 0;
    int mat3 = 1;
    private void Start()
    {
        len = mat1.Length;
    }

    // Update is called once per frame
    void Update()
    {
        t = Mathf.Lerp(t, 1f, lerptime * Time.deltaTime);

        sp.material.Lerp(mat1[mat2],mat1[mat3],lerptime * Time.deltaTime) ;

        if (t > .9f)
        {
            t = 0f;
            mat2++;
            mat3++;
            if (mat3 == len)
            {
                mat2 = 0;
                mat3 = 1;
            }
        }


      
    }
}
