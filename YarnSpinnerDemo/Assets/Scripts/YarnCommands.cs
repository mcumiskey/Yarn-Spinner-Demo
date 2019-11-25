using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yarn.Unity.Example {

    public class YarnCommands : MonoBehaviour {

        public GameObject ConfettiParticles;
        public GameObject SpaceParticles;
       /// Create a command to use on a sprite
        [YarnCommand("generateParticles")]
        public void generateParticles(string particleName) {
            if(particleName == "space") {
                Instantiate(SpaceParticles, new Vector3(0, 0, 0), Quaternion.identity);
            } else {
                Instantiate(ConfettiParticles, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
}
