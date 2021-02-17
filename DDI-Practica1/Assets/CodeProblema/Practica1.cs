using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {8,1,2,2,3};
        int[] result = NumbersLessThan(nums);
        
        PrintArrayInt(nums);
        PrintArrayInt(result);

        int[] nums2 = {-2,9,5,3,7,0,1};
        int[] result2 = NumbersLessThan(nums2);

        PrintArrayInt(nums2);
        PrintArrayInt(result2);
    }

    /* El orden de complejidad es cuadratica O(n^2)
    ya que se tienen dos for anidados y los dos son 
    del mismo tamaño n.
    La operacion puede considerarse como 3n+3 considerando
    Que los dos ifs se cumplan y tomando en cuenta las 
    3 declaraciones de variables.
    */
    private int[] NumbersLessThan(int[] nums)
    {
        int[] aux = new int[nums.Length];
        int i,j;

        for(i = 0; i < nums.Length; i++)
        {
            for(j = 0; j < nums.Length; j++)
            {
                if(i != j)
                    if(nums[i] > nums[j])
                        aux[i]++;
            }
        }

        return aux;
    }

    private void PrintArrayInt(int[] nums)
    {
        string str = "";

        str += "[";
       
        for(int i = 0; i < nums.Length; i++)
        {
            str += nums[i];

            if((i + 1) != nums.Length)
                str += ", ";
        }

        str += "]";

        Debug.Log(str);
    }
}
