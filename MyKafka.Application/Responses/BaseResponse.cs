using MyKafka.Application.Responses.Validation;

namespace MyKafka.Application.Responses
{
    public abstract class BaseResponse
    {
        public ValidationBag Bag { get; set; }
        public bool IsValid => Bag?.IsValid ?? true;
    }
}