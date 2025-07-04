using System;
using UnityEngine;
using UnityEngine.Events;

public class Lock : MonoBehaviour
{
    public UnityEvent OnUnlocked;
    public UnityEvent OnWrongKey;
    public Key targetKey;

    public void OnTriggerEnter(Collider other){
        Debug.Log($"Object found {other.transform.name}", this);
        // Key incomingKey = other.GetComponent<Key>();
        // if(incomingKey != null){
        // Unlock();
        // }else{
        //     Debug.Log($"The object is NOT a key", this);
        // }
        if(other.TryGetComponent<Key>(out Key incomingKey)){
            if(targetKey != null){
                if(targetKey == incomingKey){
                    Unlock();
                }else{
                    OnWrongKey.Invoke();
                }
            }else{
                Unlock();
            }
        }else{
            Debug.Log($"The object is NOT a key", this);
        }
    }

    private void Unlock()
    {
        Debug.Log("Lock Open", this);
        OnUnlocked.Invoke();
    }

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if(targetKey != null){

            Gizmos.color = Color.green;
            Gizmos.DrawLine(transform.position, targetKey.transform.position);
        }
        
    }
#endif

}
