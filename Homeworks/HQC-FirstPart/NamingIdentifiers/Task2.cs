namespace Mines
{
    class Factory
    {
        enum Gender { ultraBatka, coolGirl };
        class Human
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Years { get; set; }
        }
        public void CreateHuman(int magicIDNumber)
        {
            Human newHuman = new Human();
            newHuman.Years = magicIDNumber;
            if (magicIDNumber % 2 == 0)
            {
                newHuman.Name = "Батката";
                newHuman.Gender = Gender.ultraBatka;
            }
            else
            {
                newHuman.Name = "Мацето";
                newHuman.Gender = Gender.coolGirl;
            }
        }
    }
}