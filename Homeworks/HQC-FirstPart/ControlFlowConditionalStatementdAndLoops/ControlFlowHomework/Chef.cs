public class Chef
{
    private Bowl bowl;
    private Bowl GetBowl()
    {
        return new Bowl();
    }
    private Carrot GetCarrot()
    {
        return new Carrot();
    }
    private void Cut(Vegetable potato)
    {
        //
    }
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        
        Peel(potato);
        Peel(carrot);

        bowl = GetBowl();

        Cut(potato);
        Cut(carrot);

        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private void Peel(Vegetable potato)
    {
        throw new System.NotImplementedException();
    }

    private Potato GetPotato()
    {
        return new Potato();
    }
}

internal class Potato : Vegetable
{
}

internal class Vegetable
{
}

internal class Carrot : Vegetable
{
}

internal class Bowl
{
    public void Add(Vegetable vegetable)
    {
        
    }
}