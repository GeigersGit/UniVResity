using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Photon.MonoBehaviour {

	public string studentPrefab = "Student";
	public string studentLocationPrefab = "StudentHeadPosition";
	public string studentpointerPrefab = "StudentPointer";
	public string instructorPrefab = "InstructorVoice";
	public string instructorPointerPrefab = "InstructorPointer";
	public GameObject clientObjects;
	public GameObject serverObjects;
	public GameObject clientStudent;
	public GameObject clientCamera;

	//Gets called when you join a server from the main menu
	void OnJoinedRoom()
	{
		Camera.main.farClipPlane = 1000; //NetworkMainMenu.cs sets this to 0.4 to act as a gray background

		if (PhotonNetwork.playerList.Length == 1) //First person to join will act as server/classroom
		{
			clientObjects.gameObject.SetActive (false);
			serverObjects.gameObject.SetActive (true);
			clientStudent.gameObject.SetActive(false);
			clientCamera.gameObject.SetActive (false);
			GameObject instructorPos = PhotonNetwork.Instantiate (this.instructorPrefab, transform.position, Quaternion.identity, 0);
			GameObject instructorPointerPos = PhotonNetwork.Instantiate (this.instructorPointerPrefab, transform.position, Quaternion.identity, 0);
		}
		
		 else // Client
		{
			//Network spawn client position object that the server student follows
			GameObject playerPos = PhotonNetwork.Instantiate (this.studentPrefab, transform.position, Quaternion.identity, 0);
			//Network spawn client pointer object that the server student's hand follows
			GameObject playerPointer = PhotonNetwork.Instantiate (this.studentpointerPrefab, transform.position, Quaternion.identity, 0);
			GameObject playerLoc = PhotonNetwork.Instantiate (this.studentLocationPrefab, transform.position, Quaternion.identity, 0);
		}
	}


	void OnGUI()
	{
		if (PhotonNetwork.room == null) return;// Only display GUI when inside a server

		if (GUILayout.Button("Leave Room"))
			{
				PhotonNetwork.LeaveRoom();
			}
	}


	void OnDisconnectedFromPhoton()
	{
		Debug.LogWarning("Disconnected From Photon");
	}

	IEnumerator OnLeftRoom()
	{
		//wait until Photon is properly disconnected
		while (PhotonNetwork.room != null || PhotonNetwork.connected == false)
			yield return 0;

		Application.LoadLevel (Application.loadedLevel);
	}
}
