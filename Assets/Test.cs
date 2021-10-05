using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //配列の初期化
        int[] array = { 15, 23, 42, 56, 24 };
        //配列の中を順番に表示
        for(int a = 0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }
        //さっきとは逆の順番で表示
        for(int a = array.Length; a > 0; a--)
        {
            //array.Length=5なので-１する
            Debug.Log(array[a-1]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
