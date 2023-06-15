using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonBoss : MonoBehaviour
{
	public float speed = 1f;
	public float wallAware = 0.5f;
	public LayerMask groundLayer;
	public float playerAware = 3f;
	public float aimingTime = 0.5f;
	public float shootingTime = 1.5f;

 public string player;
 
 public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;


	private Rigidbody2D _rigidbody;
	private Animator _animator;
	private DemonWeapon _weapon;
	private AudioSource _audio;

	// Movement
    private bool _facingRight;

	private bool _isAttacking;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody2D>();
		_animator = GetComponent<Animator>();
		_weapon = GetComponentInChildren<DemonWeapon>();
		_audio = GetComponent<AudioSource>();
	}

	// Start is called before the first frame update
	void Start()
	{
      player = Sp.v;
		if (transform.localScale.x < 0f) {
			_facingRight = false;
		} else if (transform.localScale.x > 0f) {
			_facingRight = true;
		}
	}

	// Update is called once per frame
	void Update() 
	{
		Vector2 direction = Vector2.right;

		if (_facingRight == false) {
			direction = Vector2.left;
		}
  	if (_facingRight == false) {
			direction = Vector2.left;
		}
  if (player=="1"){   
		if (_isAttacking == false) {
		if (transform.position.x > player1.position.x && _facingRight==false)
		{
				Flip();
			}
            else if (transform.position.x < player1.position.x  && _facingRight==true)
		{
			Flip();
		}
		}}
         else if (player=="2"){   
		if (_isAttacking == false) {
		if (transform.position.x > player2.position.x && _facingRight==false)
		{
				Flip();
			}
            else if (transform.position.x < player2.position.x  && _facingRight==true)
		{
			Flip();
		}
		}}
         else if (player=="3"){   
		if (_isAttacking == false) {
		if (transform.position.x > player3.position.x && _facingRight==false)
		{
				Flip();
			}
            else if (transform.position.x < player3.position.x  && _facingRight==true)
		{
			Flip();
		}
		}}
         else if (player=="4"){   
		if (_isAttacking == false) {
		if (transform.position.x > player4.position.x && _facingRight==false)
		{
				Flip();
			}
            else if (transform.position.x < player4.position.x  && _facingRight==true)
		{
			Flip();
		}
		}}

	}





	private void LateUpdate()
	{
		_animator.SetBool("Idle", _rigidbody.velocity == Vector2.zero);
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		if (_isAttacking == false && collision.CompareTag("Player")) {
			StartCoroutine("AimAndShoot");
		}
	}

	private void Flip()
	{
		_facingRight = !_facingRight;
	transform.Rotate(0f, 180, 0f);
	}

	private IEnumerator AimAndShoot()
	{
		_isAttacking = true;

		yield return new WaitForSeconds(aimingTime);

		_animator.SetTrigger("Shoot");

		yield return new WaitForSeconds(shootingTime);

		_isAttacking = false;
	}

	void CanShoot()
	{
		if (_weapon != null) {
			_weapon.Shoot();
			}
	}

	private void OnEnable()
	{
		_isAttacking = false;
	}

	private void OnDisable()
	{
		StopCoroutine("AimAndShoot");
		_isAttacking = false;
	}
}
