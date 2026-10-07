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

    public bool hasWon;

    public GameObject Enviar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(hasWon) return;

        int correct = 0;

        for (int i = 0; i < listaDropdowns.Count; i++)
        {

            string selected = listaDropdowns[i].options[listaDropdowns[i].value].text;
            
            if(selected == Orderwords[i])
            {
                correct++;
            }
            
            if (correct == listaDropdowns.Count)
            {
                hasWon = true;

                Color ImgCor = Enviar.GetComponent<Image>().color;
                ImgCor.a = 1f;
                Enviar.GetComponent<Image>().color = ImgCor;

                Color TxtCor = Enviar.GetComponentInChildren<TMP_Text>().color;
                TxtCor.a = 1f;
                Enviar.GetComponentInChildren<TMP_Text>().color = TxtCor;

                Enviar.GetComponent<Button>().enabled = true;
            }


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
