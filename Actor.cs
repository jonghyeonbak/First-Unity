
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
        return "��ȭ�� �ɾ����ϴ�.";
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
