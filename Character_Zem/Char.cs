namespace Character_Zem
{
    public class Character
    {
        public string _name;
        public int _x;
        public int _y;
        public bool _camp;
        public int _max_HP;
        public int _current_HP;

        public Character(string name, int x, int y, bool camp, int maxHP, int currentHP)
        {
            _name = name;
            _x = x;
            _y = y;
            _camp = camp;
            _max_HP = maxHP;
            _current_HP = currentHP;
        }
    }
}