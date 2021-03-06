using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica3 : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        int[] nums = {2,7,11,15};

        PrintArrayInt(SumaDos(nums,9));
        PrintArrayInt(SumaDos2(nums,13));
        PrintArrayInt(SumaDos(nums,17));
        PrintArrayInt(SumaDos2(nums,22));
        PrintArrayInt(SumaDos(nums,10));
    }

    /* Esta función encuentra los numeros dentro de un arreglo cuya suma
    de el valor mandado en target. De no encontrarse se regresa el arreglo [-1,-1]
    Al ser una funcion con dos for anidados la complejidad del algoritmo es
    cuadratica O(n^2).

    */
    public int[] SumaDos(int[] nums, int target)
    {
        int i, j;
        int[] aux = {-1,-1};

        for(i = 0; i < nums.Length; i++)
        {
            for(j = (i+1); j < nums.Length; j++)
            {
                if((nums[i] + nums[j]) == target)
                {
                    aux[0] = i;
                    aux[1] = j;
                }
            }
            if(aux[0] != -1)
                break;
        }
         
         return aux;
    }

    public int[] SumaDos2(int[] nums, int target)
    {
        int left = 0, right = nums.Length-1;
        int[] aux = {-1,-1};

        Array.Sort(nums);

        while(left < right)
        {
            if((nums[left] + nums[right]) == target)
            {
                aux[0] = left;
                aux[1] = right;
                break;
            }
            else if((nums[left] + nums[right]) < target)
                left++;
            else
                right--;
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
