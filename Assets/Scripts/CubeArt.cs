using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeArt : MonoBehaviour
{
    [SerializeField] public Material[] materialList;
    private Renderer m_Renderer;

    private void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        StartCoroutine(SetMaterial());
    }

    IEnumerator SetMaterial()
    {
        while(true)
        {
            m_Renderer.material = materialList[Random.Range(0, materialList.Length)];
            yield return new WaitForSeconds(0.8f);
        }
       
    }


}
