using Unity.Entities;
public class CountSystem : ComponentSystem
{ 
    // Systemが要求するComponentData一覧
    struct Group
    {
        public readonly int Length;
        public ComponentDataArray<CountData> countData;
    }

    [Inject] Group group; // 要求したComponentDataを注入

    // 毎フレーム呼び出される
    protected override void OnUpdate()
    {
        for (int i = 0; i < group.Length; i++)
        {
            var countData = group.countData[i];
            countData.count++;
            group.countData[i] = countData;
        }
    }
}
