namespace CQRS_Project.Result
{
    public static class ResultExtensions
    {
        public static IResult ToHttpResult<T>(
            this Result<T> result)
        {
            if (result.IsSuccess)
            {
                return Results.Ok(result.Value);
            }

            return result.Error.Code switch
            {
                "NotFound" =>
                    Results.NotFound(result.Error),

                "Validation" =>
                    Results.BadRequest(result.Error),

                "Conflict" =>
                    Results.Conflict(result.Error),

                "Unauthorized" =>
                    Results.Unauthorized(),

                _ =>
                    Results.StatusCode(500)
            };
        }
    }
}
