using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foundAnimation : MonoBehaviour
{
    public Animator anim;
    public AudioSource As;
    public AudioClip[] sfx;
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine("startAnimation");
    }
    public IEnumerator startAnimation()
    {
        yield return new WaitForSeconds(1f);
    }

    public void playOpeningSound()
    {
        As.PlayOneShot(sfx[0]);

    }
    public void playFoundSound()
    {
        As.PlayOneShot(sfx[1]);

    }
    public void endAnimation()
    {
        gameObject.SetActive(false);

    }
}
