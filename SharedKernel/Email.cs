using StaffPortalAPI.SharedKernel;

namespace StaffPortalAPI.SharedKernel;

public sealed record Email
{
    private Email(string value) => Value = value;
    public string Value { get; }
    public static Result<Email> Create(string? email)
    {
        if (string.IsNullOrEmpty(email))
        {
            return Result.Failure<Email>(EmailErrors.Empty);
        }

        if (email.Split('@').Length != 2)
        {
            return Result.Failure<Email>(EmailErrors.InvalidFormat);
        }

        return new Email(email);
    }

    public static Email Parse(string email)
    {
        if (IsValidEmail(email))
        {
            return new Email(email);
        }
        else
        {
            throw new ArgumentException("Invalid email address format", nameof(email));
        }
    }

    public static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }

    public override string ToString() => Value;
}

public static class EmailErrors
{
    public static readonly Error Empty = new("Email.Empty", "Email is empty");

    public static readonly Error InvalidFormat = new("Email.InvalidFormat", "Email format is invalid.");
}


