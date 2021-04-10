using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableAnim : MonoBehaviour 
{
    private Animator _animator;
    // Start is called before the first frame update
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void UpdateAnimation(int option)
    {
        switch(option){
            case 1:
                _animator.SetBool("Walk",true);
                break;
            case 2:
                _animator.SetBool("Walk",false);
                break;
        }

    }
}
