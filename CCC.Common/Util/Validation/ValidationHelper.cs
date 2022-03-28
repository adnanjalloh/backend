using CCC.Common.Action;
using System.ComponentModel.DataAnnotations;

namespace CCC.Common.Util.Validation
{
    public static class ValidationHelper
    {
        public static void ValidationResults(this OperationResult result, object model)
            => result.Errors.PrepareErrors(ValidateModel(model));

        public static void ValidationResults<T>(this OperationResult<T> result, object model)
            => result.Errors.PrepareErrors(ValidateModel(model));

        public static void ValidationResults<T>(this PaggingOperationResult<T> result, object model)
            => result.Errors.PrepareErrors(ValidateModel(model));

        public static bool IsValid(object model)
            => !ValidateModel(model).Any();


        private static List<ValidationResult> ValidateModel(object model)
        {
            var context = new ValidationContext(model);
            List<ValidationResult> validationResults = new();
            Validator.TryValidateObject(model, context, validationResults, true);
            return validationResults;
        }
        private static void PrepareErrors(this List<Error> result, List<ValidationResult> validationResults)
        {
            if (validationResults is not null)
            {
                foreach (var item in validationResults)
                {
                    var error = new Error
                    {
                        ErrorMessage = item.ErrorMessage,
                    };
                    result.Add(error);
                }
            }
        }
    }
}