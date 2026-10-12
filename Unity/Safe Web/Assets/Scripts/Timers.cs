using UnityEngine;
using System.Collections;
public class Timers : MonoBehaviour
{
    [Header("Time between Notifications")]
    [SerializeField] private float StartTime;
    private float RTime;

    [Header("Phase")]
    [SerializeField] private float Phase;

    [SerializeField] private bool Chat;

    [Header("Notif GameObjects")]
    [SerializeField] private GameObject NotifEmail;
    [SerializeField] private GameObject NotifChat;
    [SerializeField] private GameObject EmailDesafio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RTime = StartTime;
        Chat = false;
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
                    EmailDesafio.gameObject.SetActive(true);
                    Chat = true;
                    break;

                default:
                    break;
            }
        }
    }

    public void OpenChat()
    {
        if (Chat == false)
        {
            NotifChat.gameObject.SetActive(false);
            RTime = StartTime;
            Phase = 2;
        }
    }
    public void OpenEmail()
    {
        if (Chat)
        {
            NotifEmail.gameObject.SetActive(false);
            EmailDesafio.gameObject.SetActive(true);
            Phase = 3;
        }
    }
}