using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _zonePrefab;
    [SerializeField] private Transform _multiplierParent;

    private const int NUM_ZONES = 2;
    private readonly int[] MULTIPLIERS = {1, 2, 3, 4};

    private void Awake()
    {
        for (int i = 0; i < NUM_ZONES; i++)
        {
            GameObject zone = Instantiate(_zonePrefab, _multiplierParent);
            zone.GetComponent<Multiplier>().SetMultiplier(Random.Range(MULTIPLIERS[0], MULTIPLIERS[MULTIPLIERS.Length]));
            zone.GetComponent<Multiplier>().Spawn();
        }
    }
}
