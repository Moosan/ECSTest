using UnityEngine;
using Unity.Entities;

public class ECSMain : MonoBehaviour
{
    void Start()
    {
        var entityManager = World.Active.GetOrCreateManager<EntityManager>();

        // Entityのアーキタイプを定義
        var sampleArchetype = entityManager.CreateArchetype(typeof(CountData));

        // アーキタイプを元にEntityを実際に生成
        entityManager.CreateEntity(sampleArchetype);
    }
}
