using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�z��̏�����
        int[] array = { 15, 23, 42, 56, 24 };
        //�z��̒������Ԃɕ\��
        for(int a = 0; a < array.Length; a++)
        {
            Debug.Log(array[a]);
        }
        //�������Ƃ͋t�̏��Ԃŕ\��
        for(int a = array.Length; a > 0; a--)
        {
            //array.Length=5�Ȃ̂�-�P����
            Debug.Log(array[a-1]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
