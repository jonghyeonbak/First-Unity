
public class Actor 
{
    int id;
    string name;
    string title;
    string weapon;
    float strength = 15.5f;
    int level;

    string Talk()
    {
        return "대화를 걸었습니다.";
    }
    
    string HasWeapon()
    {
        return weapon;
    }

    void LevelUp()
    {
        level = level + 1;
    }
}
