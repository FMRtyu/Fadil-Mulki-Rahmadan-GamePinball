using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    public float score;

    private Renderer renderer;
    private Animator animator;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();
        renderer.material.color = color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            //Debug.Log("kena bola");
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            //play sfx
            audioManager.PlaySFX(collision.transform.position);

            //playvfx
            vfxManager.PlayVFX(collision.transform.position);

            //add score
            scoreManager.AddScore(score);
        }
    }
}
