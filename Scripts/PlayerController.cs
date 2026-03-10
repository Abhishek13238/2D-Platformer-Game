using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
  public float speed = 5f;
  public AudioSource gameOver;
  public float jumpForce = 42f;
  bool isGrounded;
  bool DoubleJump;
  private Rigidbody2D rb;
  public GameObject canvas;
  private float moveInput;
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    float move = Input.GetAxis("Horizontal") + moveInput;
    rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      ButtonJump();
    }
  }

  public void moveLeft() => moveInput = -1f;
  public void moveRight() => moveInput = 1f;
  public void stopMove() => moveInput = 0f;

  public void ButtonJump()
  {
    if (isGrounded)
    {
      Jump();
      DoubleJump = true;
      isGrounded = false;
    }
    else if (DoubleJump)
    {
      rb.linearVelocity = Vector2.up * jumpForce / 1.2f;
      DoubleJump = false;
    }
  }

  void Jump() => rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

  void OnCollisionEnter2D(Collision2D col)
  {
    if (col.gameObject.CompareTag("Ground"))
    {
      isGrounded = true;
      DoubleJump = false;
    }
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("FallDeath"))
    {
      gameOver.Play();
      canvas.SetActive(true);
      Time.timeScale = 0f;
    }
    if (other.CompareTag("Enemy"))
    {
      gameOver.Play();
      canvas.SetActive(true);
      Time.timeScale = 0f;
    }
  }
}
