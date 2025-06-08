using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public string requiredKeyColor; // Primer: "Yellow"
    public static List<Door> allDoors = new List<Door>();
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();

        allDoors.Add(this); // Vrata se registruju automatski
    }

    public void Open() {
        Debug.Log("Otvaram vrata: " + gameObject.name);
        animator.SetTrigger("OpenDoor");
        StartCoroutine(DestroyAfterAnimation());
    }

    private System.Collections.IEnumerator DestroyAfterAnimation() {
        // Čekaj dok animacija traje (npr. 2 sekunde, koliko ti traje animacija)
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
