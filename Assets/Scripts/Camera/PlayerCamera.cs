using UnityEngine;

namespace Camera
{
    public class PlayerCamera : MonoBehaviour
    {
        public GameObject targetObj;
        private Vector3 PlayerLookAtPosition = new Vector3(3.7f, 5f, -6f);

        void LateUpdate()
        {
            // ���̃v���C���[�̈ʒu�̑��Έʒu�ɃJ�������X�V����
            Vector3 playerPos = targetObj.transform.position;
            this.transform.position = playerPos + PlayerLookAtPosition;
        }
    }
}