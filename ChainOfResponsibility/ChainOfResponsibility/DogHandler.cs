namespace ChainOfResponsibility
{
    public class DogHandler : BaseHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Meat")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }

            return base.Handle(request);
        }
    }
}