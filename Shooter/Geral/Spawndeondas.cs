using System.Collections;
using UnityEngine;

public class Spawndeondas : MonoBehaviour{

    public enum SpawnState {Spawning,Waiting,Counting};
    
    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public int contador;
        public float rate;
    }

    public Wave [] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;


    public float timeBetweenWaves = 5f;
    public float waveCountdown;

    private float searchCountdown = 1f;

    private SpawnState state = SpawnState.Counting;

    void Start () {
        waveCountdown = timeBetweenWaves;


    }

    void Update(){
    
        if(state == SpawnState.Waiting)
        {
            //check if enemies are still alive
            // se a função retorna falso por isso a exclamação
            if (!EnemyIsAlive()){
                
                waveCompleted();
                //begin a new round
            }
            else{
                return;
            }

        }
        if (waveCountdown <= 0)
        {
            if(state != SpawnState.Spawning)
            {  
                StartCoroutine( SpawnWave (waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void waveCompleted(){
        Debug.Log("Wavecompleted");

        state = SpawnState.Counting;
        waveCountdown = timeBetweenWaves;


        if(nextWave + 1  > waves.Length -1 )
        {
            nextWave = 0;
            Debug.Log("you win");
        }
        else{
            nextWave++;
        }

    }

    bool EnemyIsAlive()
    {    
        searchCountdown -= Time.deltaTime;
        if(searchCountdown <= 0f)
        {
            searchCountdown =1f;

        // outro metedo parecido para verificar se todo mundo morreu seria
        //if(GameObject.FindGameObjectWithTag("Enemy") == null) perceba object ta no singular
            if (GameObject.FindGameObjectsWithTag ("Enemy").Length == 0)
            {
               return false;
            }
        }
        return true;
        
    }

    IEnumerator SpawnWave(Wave _wave)
    {   
        Debug.Log("wave começamdo: " + _wave.name);
        state = SpawnState.Spawning;

        for (int i = 0; i < _wave.contador; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f/_wave.rate );
            
        }

        state = SpawnState.Waiting;

        yield break;
    }

    void SpawnEnemy (Transform _enemy)
    {
        
        Debug.Log("vaiiii" + _enemy.name);
        Transform _sp= spawnPoints[ Random.Range (0,spawnPoints.Length)];
        Instantiate(_enemy, _sp.position,_sp.rotation);
        //spawn enemy
        
    }




}
