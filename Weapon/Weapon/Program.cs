    class Weapon
    {
        public int Damage { get; private set; }
        public int Bullets { get; private set; }
    
        public void Fire(Player player)
        {
            player.TakeDamage(Damage);
            Bullets -= 1;
        }
    }
    
    class Player
    {
        public int Health { get; private set; }
    
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
    
    class Bot
    {
        public Weapon Weapon { get; private set; }
    
        public void OnSeePlayer(Player player)
        {
           Weapon.Fire(player);
        }
    }