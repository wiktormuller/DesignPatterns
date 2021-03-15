namespace ChainOfResponsibility
{
    public class SquirrelHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.";
            }

            return base.Handle(request);
        }
    }
}