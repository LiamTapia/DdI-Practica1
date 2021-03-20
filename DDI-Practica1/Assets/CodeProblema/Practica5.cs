using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums1 = {12,345,2,6,7896,3,65,89,975,98745};
        int[] nums2 = {3,3,9,9,4,3,1,2,1,2};

        PrintArrayInt(nums1);
        Debug.Log(parDigitArray(nums1));

        PrintArrayInt(nums2);
        Debug.Log(singleNumArray(nums2));
    }

    int parDigitArray(int[] nums)
    {
        int i = 0, aux = 10, counter = 0;
        bool toggler = false;

        Array.Sort(nums);
        
        while(i < nums.Length)
        {
            if(nums[i] < aux)
            {
                i++;
                if(toggler)
                    counter++;
            }
            else
            {
                aux *= 10;
                toggler = !toggler;
            }
        }

        return counter;
    }

    int singleNumArray(int[] nums)
    {
        int i, j, aux;

        Array.Sort(nums);

        for(i = 0; i < nums.Length; i++)
        {
            aux = nums[i];

            if((i+1) < nums.Length)
                j = i+1;
            else
                break;

            if(aux == nums[j])
            {
                while(aux == nums[j])
                    j++;
                i = j-1;
            }
            else
                break;
        }

        return nums[i];
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
