using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroOOP
{
    class Superhero
    {

        //DECLARE FIELDS
        private string strength;
        private string secretIdentity;
        private string weakness;
        private string name;
        //END DECLARE FIELDS

        //DECLARE PROPERTIES
        public string Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }

        public string Weakness
        {
            get { return this.weakness; }
            set { this.weakness = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        //END DECLARE PROPERTIES

        //CONSTRUCTORS
        public Superhero() {
            //DEFAULT CONSTRUCTOR
        }

        //LOADED CONSTRUCTOR
        public Superhero(string strength, string secretIdentity, string weakness, string name)
        {
            this.strength = strength;
            this.secretIdentity = secretIdentity;
            this.weakness = weakness;
            this.name = name;
        }
        //END LOADED CONSTRUCTOR

        public void StrengthOne()
        {
            Console.WriteLine("Super Butt Head's real name is " + SecretIdentity);
        }


        public void FavFood(string[] food)
        {
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("{0}'s favorite foods are: ", Name);
                Console.ReadLine();
                Console.WriteLine(food[i]);
            }
              
        }

    }

    }

