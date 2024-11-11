using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanel : MonoBehaviour
{

    [SerializeField] Animator fadePanel;
    
        
    // Start is called before the first frame update
    void Start()
    {
        fadePanel.Play("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
