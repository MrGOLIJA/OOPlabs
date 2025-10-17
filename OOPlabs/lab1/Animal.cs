
namespace OOPlabs
{
    class Animal
    {
        private string _name { get; }
        private int _age;
        private int countHand;
        private kind _type;
        private habitat _habitat;
        private continent _continent;
        private string _sound;



        public Animal()
        {
            _name = "Животное";
            _age = 0;
            countHand = 0;
            _type = kind.Хищник;
            _habitat = habitat.НаземноВоздушная;
            _continent = continent.Евразия;
            _sound = "Звук";
        }
        public Animal(string name, int age, int limbs, kind type, habitat hab, continent continent, string sound)
        {
            _name = name;
            _age = age;
            countHand = limbs;
            _type = type;
            _habitat = hab;
            _continent = continent;
            _sound = sound;
        }

        public int Age { set { _age = value; } }

        public string Name {  get { return _name; } }

        static public bool operator ==(Animal animal1, Animal animal2)
        {
            return animal1 != null && animal2 != null &&
                animal1._name == animal2._name &&
                animal1._age == animal2._age &&
                animal1._type == animal2._type &&
                animal1._continent == animal2._continent &&
                animal1._sound == animal2._sound &&
                animal1._habitat == animal2._habitat &&
                animal1.countHand == animal2.countHand;
        }

        static public bool operator !=(Animal animal1, Animal animal2)
        {
            return !(animal1 == animal2);
        }

        public string getSound()
        {
            return this._sound;
        }

        public bool canFly()
        {
            return this.countHand == 2 && this._habitat == habitat.НаземноВоздушная;
        }

        public bool canSwim()
        {
            return this._habitat == habitat.Водная;
        }

        public bool ExistsTail()
        {
            return this._name != "Человек" && this._name != "Осьминог";
        }
    }
}
