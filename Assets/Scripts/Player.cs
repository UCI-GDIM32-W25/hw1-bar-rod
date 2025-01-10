using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    

    private void Start ()
    {
        
    }

    private void Update()
    {
        //making the player move
        if (Input.GetKey(KeyCode.W)) {
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.A)) {
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.S)) {
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

         if (Input.GetKey(KeyCode.D)) {
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);
        }

        //when player presses space, a seed will be planted 
        if (Input.GetKeyDown(KeyCode.Space)){
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeeds > 0){
            GameObject seedObject = Instantiate(_plantPrefab) as GameObject;
            seedObject.transform.position = _playerTransform.transform.position;
            _numSeeds --;
        }
    }
}
