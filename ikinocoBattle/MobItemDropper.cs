using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(MobStatus))]

public class MobItemDropper : MonoBehaviour
{
    [SerializeField] [Range(0, 1)] private float dropRate = 0.1f;
    [SerializeField] private Item itemPrefab;
    [SerializeField] private int number = 1;

    private MobStatus _status;
    private bool _isDropInvoked;
    private void Start()
    {
        _status = GetComponent<MobStatus>();        
    }

    private void Update()
    {
        if (_status.Life <= 0)
        {
            DropIfNeeded();
        }
    }

    private void DropIfNeeded()
    { 
        if(_isDropInvoked) return;

        _isDropInvoked = true;

        if (Random.Range(0, 1f) >= dropRate) return;

        for (var i = 0; i < number; i++) 
        {
            var item = Instantiate(itemPrefab, transform.position, Quaternion.identity);
            item.Initialize();
        }
    }
}
