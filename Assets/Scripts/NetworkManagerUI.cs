using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{

    [SerializeField] private Button btnStartServer;
    [SerializeField] private Button btnStartHost;
    [SerializeField] private Button btnStartClient;

    // Start is called before the first frame update
    private void Awake()
    {
        btnStartServer.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer();
        });

        btnStartHost.onClick.AddListener(() => {
            NetworkManager.Singleton.StartHost();
        });

        btnStartClient.onClick.AddListener(() => {
            NetworkManager.Singleton.StartClient();
        });
    }
}
