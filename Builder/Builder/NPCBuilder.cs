namespace Builder;

public class NPCBuilder : IBuilder
{
    public NPC npc = new();

    public NPCBuilder GetNPC()
    {
        return this;
    }

    public void SetName(string name)
    {
        npc.Name = name;
    }

    public void SetHealth(int health)
    {
        npc.Health = health;
    }

    public void SetStamina(int stamina)
    {
        npc.Stamina = stamina;
    }

    public void SetDifficulty(int difficulty)
    {
        npc.Difficulty = difficulty;
    }

    public void Build()
    {
        Console.WriteLine("\n\tName: " + npc.Name);
        Console.WriteLine("\tHealth: " + npc.Health);
        Console.WriteLine("\tStamina: " + npc.Stamina);
        Console.WriteLine("\tDifficulty: " + npc.Difficulty);
    }
}