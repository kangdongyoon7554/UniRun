using UnityEngine;
//������Ʈ ����->�̸� ��� ������Ʈ�� �����ϰ� ��Ȱ��
public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject platPrefab;
    int count = 3;

    //������ ���� ����->timer
    float spawnMin = 1.25f;
    float spawnMax = 2.25f;
    float spawnTime;

    //������ �����
    float posX = 20;
    float yMin = -3.5f;
    float yMax = 1.5f;
    float posY;

    GameObject[] platforms;
    int currIndex = 0;

    Vector3 poolPosition = new Vector3(0, -25, 0);
    float lastSpawnTime;
    
    void Start()
    {
        platforms = new GameObject[count];
        //ctrl+k,d
        for (int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(platPrefab, poolPosition, Quaternion.identity);
        }

        // ������ ��ġ ���� �ʱ�ȭ
        lastSpawnTime = 0f;
        // ������ ��ġ������ �ð� ������ 0���� �ʱ�ȭ
        spawnTime = 0f;
    }


    void Update()
    {
        if (GameManager.instance.isGameover) return;

        //������ ��ġ ���� ����....
        if (Time.time >= lastSpawnTime + spawnTime)
        {
            lastSpawnTime = Time.time;
            spawnTime = Random.Range(spawnMin, spawnMax); // 1.25~2.25

            platforms[currIndex].SetActive(false);
            platforms[currIndex].SetActive(true);

            posY = Random.Range(yMin, yMax); // -3.5 ~ 1.5
            platforms[currIndex].transform.position = new Vector2(posX, posY);

            if (++currIndex == count) currIndex = 0;
        }
    }
}
