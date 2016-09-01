namespace ControlFlowHomework
{
    public class RefactorIfStatements
    {
        Potato potato;
//... 
        if (potato != null)
        {
            if (!(potato.HasNotBeenPeeled && potato.IsRotten))
            {
                Cook(potato);
            }
}
        bool isYIsBetweenMinAndMax = MAX_Y >= y && MIN_Y <= y;
        if (x >= MIN_X && (x =< MAX_X && (!shouldNotVisitCell && isYIsBetweenMinAndMax )))
        {
           VisitCell();
        }

    }
}