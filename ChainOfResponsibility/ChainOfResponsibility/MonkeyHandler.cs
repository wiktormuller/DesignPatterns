namespace ChainOfResponsibility
{
    public class MonkeyHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.";
            }
            
            return base.Handle(request);
        }
    }
}