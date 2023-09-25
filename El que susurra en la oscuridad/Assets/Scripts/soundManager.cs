using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public GameObject sonidoIntro;
    public GameObject sonidoDesicion;

    IEnumerator ApplySound()
    {
        sonidoDesicion.SetActive(false);
        yield return new WaitForSeconds(10);
        sonidoDesicion.SetActive(true);
    }
    
    void Start()
    {
        
        sonidoDesicion.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
