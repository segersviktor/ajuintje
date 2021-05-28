﻿using System.Collections.Generic;
using System.Linq;

namespace MyKafka.Application.Responses.Validation
{
    public class ValidationBag
    {
        private readonly List<Error> _errors;
        public IEnumerable<Error> Errors => _errors.AsEnumerable();

        public ValidationBag()
        {
            _errors = new List<Error>();
        }

        public void AddError(ValidationErrorCode error)
        {
            _errors.Add(new Error(error));
        }

        public void AddErrors(List<ValidationErrorCode> errors)
        {
            errors.ForEach(error => _errors.Add(new Error(error)));
        }

        public void AddError(ValidationErrorCode error, object parameters)
        {
            _errors.Add(new Error(error, parameters));
        }

        public bool IsValid => !_errors.Any();
    }
}