using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DropDowns : MonoBehaviour
{
    [Header("Dropdown list")]
    [SerializeField] public List<TMP_Dropdown> listaDropdowns;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Found(string Text)
    {
        foreach(TMP_Dropdown dd in listaDropdowns)
        {
            TMP_Dropdown.OptionData novaop = new TMP_Dropdown.OptionData();
            novaop.text = Text;
            dd.options.Add(novaop);
        }
    }
}
