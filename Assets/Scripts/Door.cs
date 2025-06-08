using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
    public string requiredKeyColor; // Primer: "Yellow"
    public static List<Door> allDoors = new List<Door>();

    private void Awake() {
        allDoors.Add(this); // Vrata se registruju automatski
    }

    public void Open() {
        Debug.Log("Otvaram vrata: " + gameObject.name);
        Destroy(gameObject); // ili animacija umesto Destroy
    }
}
