using LevelSystem;
using UnityEngine;

namespace LevelSystem
{
  public class LevelBuild
  {
    private readonly GameObject _startPref;
    private readonly GameObject _endLevelPrefab;
    private readonly GameObject[] _pref;
    private int _difficult;
    private const float _spacing = 33f;

    public LevelBuild(GameObject[] prefab, int difficult, GameObject endLevelPrefab,GameObject start)
    {
      _startPref = start;
      _endLevelPrefab = endLevelPrefab;
      _pref = prefab;
      _difficult = difficult;
    }

    public void GenerateLevel()
    {

      Vector3 startPosition = new Vector3(0, 0, 0);
      Object.Instantiate(_startPref, startPosition, Quaternion.identity);

      for (int i = 0; i < _difficult; i++)
      {
        int randomIndex = Random.Range(0, _pref.Length);
        GameObject locationPrefab = _pref[randomIndex];
        
        Vector3 position = new Vector3((i + 1) * _spacing, 0, 0); 

        Object.Instantiate(locationPrefab, position, Quaternion.identity);
      }
      Vector3 endPosition = new Vector3((_difficult + 1) * _spacing, 0, 0); 
      Object.Instantiate(_endLevelPrefab, endPosition, Quaternion.identity);
    }
  }
}
