using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//You can use any namespace, it just needs to match the Dialogue UI
namespace Yarn.Unity.Demo {

    public class YarnCommands : MonoBehaviour {

        //this GameObject is my glitter particle effect prefab
        public GameObject SpaceParticles;
       
       /// Create a command and call it "generateParticles"
        [YarnCommand("generateParticles")]
        //the yarn command's effect is on the function underneath it
        //all parameters MUST be strings
        //The yarn function is called with <<CommandName GameObject StringParameters>>
        //ie this is <<generateParticles GameController space>>
        public void generateParticles(string particleName) {
            //if the parameter is space
            if(particleName == "space") {
                //create the glitter prefab
                Instantiate(SpaceParticles, new Vector3(0, 0, 0), Quaternion.identity);
            } else {
                //do nothing
            }
        }
    }
}
