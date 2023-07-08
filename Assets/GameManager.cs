using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float spwanFreqSeconds = 5f;
    void Start() { StartCoroutine(SpawnCubes());}

    IEnumerator SpawnCubes() {
        while(true) {
            yield return new WaitForSeconds(spwanFreqSeconds);
            Vector3 pos = GetRandomPos();
            Instantiate(prefab, new Vector3(pos.x, prefab.transform.position.y, pos.z), Quaternion.identity);
        }
    }

    Vector3 GetRandomPos() {
        // hardcoded for now
        float x = Random.Range(-22, 22);
        float z = Random.Range(-22, 22);
        return new Vector3(x, 0, z);
    }
}
