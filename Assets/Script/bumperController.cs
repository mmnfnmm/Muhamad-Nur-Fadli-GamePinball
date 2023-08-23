using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class bumperController : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager VFXManager;

    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);

            VFXManager.PlayVFX(collision.transform.position);

            scoreManager.AddScore(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
