using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public string requiredKeyColor; // Primer: "Yellow"
    public static List<Door> allDoors = new List<Door>();
    private Animator animator;
    private AudioMenager audioMenager;


    private void Awake() {
        animator = GetComponent<Animator>();

        allDoors.Add(this); // Vrata se registruju automatski
        audioMenager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioMenager>();

    }

    public void Open() {
        Debug.Log("Otvaram vrata: " + gameObject.name);
        audioMenager.PlaySFX(audioMenager.doors);
        animator.SetTrigger("OpenDoor");
        StartCoroutine(DestroyAfterAnimation());
    }

    private System.Collections.IEnumerator DestroyAfterAnimation() {
        // Čekaj dok animacija traje (npr. 2 sekunde, koliko ti traje animacija)
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
