using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    private HashSet<GameObject> playersInPortal = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playersInPortal.Add(other.gameObject); // Dodaje se samo jednom, jer HashSet ne dozvoljava duplikate

            if (playersInPortal.Count == 2)
            {
                
                // Ovde pozovi kraj igre ili neku scenu ili UI
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playersInPortal.Remove(other.gameObject);
        }
    }


}

