using Photon.Pun;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public void ConnectToServer()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room1", new Photon.Realtime.RoomOptions { MaxPlayers = 2 }, null);
    }
}
