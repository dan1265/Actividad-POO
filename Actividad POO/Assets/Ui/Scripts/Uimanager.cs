using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Uimanager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Slider Life;
    [SerializeField] private Slider Mana;

    [SerializeField] private List<TextMeshProUGUI> names;
    [SerializeField] private List<TextMeshProUGUI> cds; 
    private void Awake()
    {
        Life.gameObject.SetActive(true);
        Mana.gameObject.SetActive(true);
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        foreach(TextMeshProUGUI text in cds)
        {
            if(text.text == "0,0")
            {
                text.gameObject.SetActive(false);
            }
            else
            {
                text.gameObject.SetActive(true);
            }
        }

        if (player.GetComponent<Priest>())
        {
            Life.value = player.GetComponent<Priest>().lifesystem.CurrentLife /100;
            Mana.value = player.GetComponent<Priest>().mana.CurrentMana /100;

            for (int i = 0; i < cds.Count; i++)
            {
                names[i].text = player.GetComponent<Priest>().abilitiesData[i].abilityName;
                cds[i].text = player.GetComponent<Priest>().abilities[i].cDtimer.ToString("F1");
            }
        }
        else if (player.GetComponent<Demon>())
        {
            Life.value = player.GetComponent<Demon>().lifesystem.CurrentLife /100;
            Mana.gameObject.SetActive(false);

            for (int i = 0; i < cds.Count; i++)
            {
                names[i].text = player.GetComponent<Demon>().abilitiesData[i].abilityName;
                cds[i].text = player.GetComponent<Demon>().abilities[i].cDtimer.ToString("F1");
            }
        }
        else
        {
            Debug.Log("No hay jugador");
        }
    }
}
