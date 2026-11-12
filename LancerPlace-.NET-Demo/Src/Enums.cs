
using System.Text.Json.Serialization;

namespace LancerPlace_.NET_Demo.Src;

[JsonConverter(typeof(JsonStringEnumConverter<ProjectStatus>))]
public enum ProjectStatus
{
    SPAM,
    REVIEWING,
    HIRING,
    RUNNING,
    COMPLETED,
    CANCELED
}

[JsonConverter(typeof(JsonStringEnumConverter<ApplicationStatus>))]
public enum ApplicationStatus
{
    PENDING,
    READ,
    COLLABORATING,
    REJECTED,
    DONE,
    SPAM
}

[JsonConverter(typeof(JsonStringEnumConverter<TransactionStatus>))]
public enum TransactionStatus
{
    PENDING,
    SUCCESSFUL,
    FAILED,
    REFUNDED,
    EXPIRED
}

[JsonConverter(typeof(JsonStringEnumConverter<Role>))]
public enum Role
{
    USER,
    ADMIN
}

[JsonConverter(typeof(JsonStringEnumConverter<MessageType>))]
public enum MessageType
{
    TEXT,
    FILE
}

[JsonConverter(typeof(JsonStringEnumConverter<SpamType>))]
public enum SpamType
{
    PROJECT,
    APPLICATION,
    CONVERSATION,
    ENDORSEMENT
}
[JsonConverter(typeof(JsonStringEnumConverter<SpamStatus>))]
public enum SpamStatus
{
    PENDING,
    NO_ACTION,
    MODERATED
}

[JsonConverter(typeof(JsonStringEnumConverter<TargetProfile>))]
public enum TargetProfile
{
    FREELANCER,
    CLIENT
}

[JsonConverter(typeof(JsonStringEnumConverter<TokenPeriod>))]
public enum TokenPeriod
{
    ONE_MONTH,
    THREE_MONTH,
    SIX_MONTH
}

[JsonConverter(typeof(JsonStringEnumConverter<TransactionType>))]
public enum TransactionType
{
    TOKEN,
    FINANCIAL_SUPPORT,
    PROJECT_PROMO
}

[JsonConverter(typeof(JsonStringEnumConverter<ProjectPromoType>))]
public enum ProjectPromoType
{
    LADDER,
    PIN,
    URGENT
}

[JsonConverter(typeof(JsonStringEnumConverter<LogType>))]
public enum LogType
{
    PROJECT,
    APPLICATION
}

[JsonConverter(typeof(JsonStringEnumConverter<ModerationType>))]
public enum ModerationType
{
    CLIENT_CREATE_PROJECT,
    FREELANCER_CREATE_APPLICATION
}

[JsonConverter(typeof(JsonStringEnumConverter<EndorsementStatus>))]
public enum EndorsementStatus
{
    PUBLISHED,
    SPAM
}

[JsonConverter(typeof(JsonStringEnumConverter<ModerationCause>))]
public enum ModerationCause
{
    SPAM
}

[JsonConverter(typeof(JsonStringEnumConverter<BookmarkTarget>))]
public enum BookmarkTarget
{
    PROJECT
}
[JsonConverter(typeof(JsonStringEnumConverter<ConversationStatus>))]
public enum ConversationStatus
{
    NOT_STARTED,
    OPEN,
    CLOSED,
    SPAM
}
[JsonConverter(typeof(JsonStringEnumConverter<ModerationDuration>))]
public enum ModerationDuration
{
    ONE_DAY,
    ONE_WEEK,
    ONE_MONTH,
}
