namespace Network
{
    using Unity.Netcode;
    using UnityEngine;

    public class NetworkConnectionManager : MonoBehaviour
    {
        public void StartHost()
        {
            NetworkManager.Singleton.StartHost();
            Debug.Log("Started Host");
        }

        public void StartServer()
        {
            NetworkManager.Singleton.StartServer();
            Debug.Log("Started Server");
        }

        public void StartClient()
        {
            NetworkManager.Singleton.StartClient();
            Debug.Log("Started Client");
        }
    }

}