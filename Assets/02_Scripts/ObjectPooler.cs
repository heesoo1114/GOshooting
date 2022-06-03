using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    [SerializeField] GameObject prefab;
    [SerializeField] int poolSize = 10;

    List<GameObject> prefabsList = new List<GameObject>();
    
    
    // Start is called before the first frame update
    void Start()
    {
        for( int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab);
            obj.SetActive(false); // ��� ���ϴϱ� False�� ��
            prefabsList.Add(obj);
        }
    }

    public GameObject SpawnObject(Vector3 position, Quaternion rotation)
    {

        GameObject newObj;

        if (prefabsList.Count > 0) // List�� Ȱ��ȭ�� ��ü�� �ִ� ���
        {
            newObj = prefabsList[0];
            prefabsList.RemoveAt(0); // ����
        }
        else // List�� ��Ȱ��ȭ�� ��ü�� ���� ���
        {
            newObj = Instantiate(prefab);
        }

        newObj.SetActive(true);
        newObj.transform.position = position;
        newObj.transform.rotation = rotation;
        return newObj;

    }

    public void ReturnObject(GameObject returnObj)
    {
        returnObj.SetActive(false);
        prefabsList.Add(returnObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
