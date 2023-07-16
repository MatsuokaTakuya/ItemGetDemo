using UnityEngine;

public class WalkMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody _rigidbody;
    [SerializeField]
    Animator animator;

    readonly float speed = 3.6f;

    Quaternion targetRotate;

    private void Awake()
    {
        targetRotate = transform.rotation;
    }
    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        var vertical = Input.GetAxis("Vertical") * speed;

        var vec = new Vector3(horizontal, 0f, vertical);

        var blend = Mathf.Max(Mathf.Abs(horizontal), Mathf.Abs(vertical));
        animator.SetFloat("Blend", blend);
        // ˆê’è’lˆÈã‚Å‚È‚¢‚ÆŒü‚«‚ğ•Ï‚í‚ç‚È‚¢‚æ‚¤‚Éİ’è‚·‚é
        if (vec.magnitude > 0.05f)
        {
            targetRotate = Quaternion.LookRotation(vec, Vector3.up);
        }
        // To FromŠÔ‚Ì‰ñ“]‚ğ‚È‚ß‚ç‚©‚É‚·‚é
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotate, 600 * Time.fixedDeltaTime);
        //d—Í‚Ì‰e‹¿‚ğ‚È‚­‚·‚½‚ßŒ³‚ÌVelocity Y‚ğİ’è‚·‚é
        vec.y = _rigidbody.velocity.y;
        _rigidbody.velocity = vec;
    }

    void FixedUpdate()
    {
        Move();
    }
}
