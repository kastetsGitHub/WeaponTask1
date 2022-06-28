        class Weapon
        {
            public int Damage { get; private set; }
            public int Bullets { get; private set; }

            public void Fire(Player player)
            {
                if (Bullets > 0)
                {
                    player.TakeDamage(Damage);
                    Bullets -= 1;
                }
            }
        }

        public class Player
        {
            public int Health { get; private set; }

            public event Action Killed;

            public void TakeDamage(int damage)
            {
                if (damage > 0) 
                {
                    int currentHealth = Health - damage;

                    if (currentHealth < 0)
                    {
                        Health = 0;
                        Killed?.Invoke();
                    }

                    Health = currentHealth;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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
