using UnityEngine;
using System.Collections;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class DropDowns : MonoBehaviour
{
    [Header("Lists")]
    [SerializeField] public List<TMP_Dropdown> listaDropdowns;
    [SerializeField] public List<string> Orderwords;

    public int X = 0;

    public int Win = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (TMP_Dropdown dd in listaDropdowns)
        {
            
            int selectedIndex = listaDropdowns[X].value;
            if (listaDropdowns[X].options[selectedIndex].text == Orderwords[X])
            {
                Win++;
            }

            if (X > 2)
            {
                if (Win == 3)
                {
                    Debug.Log("WIN");
                }
                else { Win = 0;}

                X = 0;

            }
            else { X++; }
            
        }
    }

    public void Found(string Text)
    {
        foreach (TMP_Dropdown dd in listaDropdowns)
        {
            TMP_Dropdown.OptionData novaop = new TMP_Dropdown.OptionData();
            novaop.text = Text;
            dd.options.Add(novaop);
        }
    }
}
