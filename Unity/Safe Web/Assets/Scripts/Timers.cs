using UnityEngine;
using System.Collections;
public class Timers : MonoBehaviour
{
    [Header("Time between Notifications")]
    [SerializeField] private float StartTime;
    private float RTime;

    [Header("Phase")]
    [SerializeField] private float Phase;

    [Header("Notif GameObjects")]
    [SerializeField] private GameObject NotifEmail;
    [SerializeField] private GameObject NotifChat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RTime = StartTime;
        Phase = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (RTime > 0) { RTime -= Time.deltaTime; }
        else 
        {
            switch (Phase)
            {
                case 1:
                    NotifChat.gameObject.SetActive(true);
                    break;

                case 2:
                    NotifEmail.gameObject.SetActive(true);
                    break;

                default:
                    break;
            }
        }
    }

    public void OpenChat()
    {
        NotifChat.gameObject.SetActive(false);
        Phase = 2;
        RTime = StartTime;
    }
    public void OpenEmail()
    {
        NotifEmail.gameObject.SetActive(false);
        Phase = 3;
    }
}