using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 PlayerLookAtPosition = new Vector3(3.7f, 5f, -6f);

    void LateUpdate()
    {
        // 今のプレイヤーの位置の相対位置にカメラを更新する
        Vector3 playerPos = player.transform.position;
        this.transform.position = playerPos + PlayerLookAtPosition;
    }
}
